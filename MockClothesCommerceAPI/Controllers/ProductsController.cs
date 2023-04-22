using Microsoft.AspNetCore.Mvc;
using MockClothesCommerceAPI.Contracts.Product;
using MockClothesCommerceAPI.Models;
using MockClothesCommerceAPI.Services.Product;

namespace MockClothesCommerceAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductsController : ControllerBase
{
    private readonly IProductService _productService;

    public ProductsController(IProductService productService)
    {
        _productService = productService;
    }

    [HttpGet]
    public IActionResult GetProducts()
    {
        var products = _productService.GetProducts();

        return Ok(products);
    }

    [HttpGet("{productId}")]
    [ProducesResponseType(404)]
    [ProducesResponseType(200)]
    public IActionResult GetProduct(int productId)
    {
        if (!_productService.ProductExists(productId)) return NotFound();

        var product = _productService.GetProduct(productId);

        if (!ModelState.IsValid) return BadRequest(ModelState);

        return Ok(product);
    }

    [HttpPost]
    public IActionResult CreateProduct([FromBody] CreateProductRequest request)
    {
        if (request is null) return BadRequest(ModelState);
        var product = _productService.GetProducts()
            .Where(u => u.Name.Trim().ToUpper() == request.Name.TrimEnd().ToUpper())
            .FirstOrDefault();

        if (product != null)
        {
            ModelState.AddModelError("", "Product already exists");
            return StatusCode(422, ModelState);
        }

        if (!ModelState.IsValid) return BadRequest(ModelState);

        var newProduct = new Product
        {
            Name = request.Name,
            Description = request.Description,
            Price = request.Price,
            CreatedAt = DateTime.UtcNow,
            ModifiedAt = DateTime.UtcNow,
            Tags = request.Tags,
        };

        if (!_productService.CreateProduct(newProduct))
        {
            ModelState.AddModelError("", "Something went wrong while savin");
            return StatusCode(500, ModelState);
        }

        return Ok(newProduct);
    }



    [HttpPut("{productId}")]
    public IActionResult UpdateProduct([FromRoute] int productId, UpdateProductRequest updateProductRequest)
    {

        if (updateProductRequest == null)
            return BadRequest(ModelState);

        if (!_productService.ProductExists(productId))
            return NotFound();
        if (!ModelState.IsValid)
            return BadRequest(ModelState);


        if (!_productService.UpdateProduct(productId, updateProductRequest))
        {
            ModelState.AddModelError("", "Something went wrong updating product");
            return StatusCode(500, ModelState);
        }

        return NoContent();
    }


    [HttpDelete("{id}")]
    public IActionResult DeleteProduct(int id)
    {
        var productToDelete = _productService.GetProduct(id);
        if (productToDelete is null) return NotFound();
        _productService.DeleteProduct(productToDelete);
        return NoContent();
    }

}