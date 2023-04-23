using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MockClothesCommerceAPI.Dtos;
using MockClothesCommerceAPI.Models;
using MockClothesCommerceAPI.Services.Category;
using MockClothesCommerceAPI.Services.Product;
using MockClothesCommerceAPI.Services.Review;
using MockClothesCommerceAPI.Services.User;

namespace MockClothesCommerceAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductsController : ControllerBase
{
    private readonly IProductService _productService;
    private readonly IReviewService _reviewService;
    private readonly ICategoryService _categoryService;
    private readonly IUserService _userService;
    private readonly IMapper _mapper;

    public ProductsController(IProductService productService,
        IReviewService reviewService,
        ICategoryService categoryService,
        IUserService userService,
        IMapper mapper)
    {
        _productService = productService;
        _reviewService = reviewService;
        _categoryService = categoryService;
        _userService = userService;
        _mapper = mapper;
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
    public IActionResult CreateProduct([FromBody] CreateProductRequest createdProduct)
    {
        if (createdProduct is null) return BadRequest(ModelState);
        if (!_categoryService.CategoryExists(createdProduct.CategoryId)) return NotFound("Category not found");
        var category = _categoryService.GetCategory(createdProduct.CategoryId);
        var product = _productService.GetProducts()
            .Where(u => u.Name.Trim().ToUpper() == createdProduct.Name.TrimEnd().ToUpper())
            .FirstOrDefault();

        if (product != null)
        {
            ModelState.AddModelError("", "Product already exists");
            return StatusCode(422, ModelState);
        }

        if (!ModelState.IsValid) return BadRequest(ModelState);

        var newProduct = _mapper.Map<Product>(createdProduct);

        if (!_productService.CreateProduct(newProduct))
        {
            ModelState.AddModelError("", "Something went wrong while savin");
            return StatusCode(500, ModelState);
        }

        var createdProductResponse = _mapper.Map<CreateProductResponse>(newProduct);

        return Ok(createdProductResponse);
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

    [HttpPost("{productId}/reviews")]
    public IActionResult AddAReview([FromBody] CreateReviewRequest request)
    {
        if (request is null) return BadRequest(ModelState);

        var product = _productService.GetProduct(request.ProductId);
        var user = _userService.GetUser(request.UserId);
        if (product is null) return NotFound("Product does not exists");
        if (user is null) return NotFound("User does not exists");

        var newReview = _mapper.Map<Review>(request);

        if (!_reviewService.CreateReview(newReview))
        {
            ModelState.AddModelError("", "Something went wrong while adding a review");
            return StatusCode(500, ModelState);
        }

        var createdReviewResponse = _mapper.Map<CreateReviewResponse>(newReview);

        if (!ModelState.IsValid) return BadRequest(ModelState);

        return Ok(createdReviewResponse);
    }

    [HttpGet("{productId}/reviews")]
    public IActionResult GetReviews(int productId)
    {
        if (!_productService.ProductExists(productId)) return NotFound();

        var reviewsMap = _mapper.Map<List<GetReviewResponse>>(_productService.GetReviews(productId));

        if (!ModelState.IsValid) return BadRequest(ModelState);

        return Ok(reviewsMap);
    }

}