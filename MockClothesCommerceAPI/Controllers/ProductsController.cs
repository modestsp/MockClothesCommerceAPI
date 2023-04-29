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
  public async Task<IActionResult> GetProducts()
  {
    var products = await _productService.GetProducts();

    return Ok(products);
  }

  [HttpGet("{productId}")]
  [ProducesResponseType(404)]
  [ProducesResponseType(200)]
  public async Task<IActionResult> GetProduct(int productId)
  {
    if (!await _productService.ProductExists(productId)) return NotFound();

    var product = await _productService.GetProduct(productId);

    if (!ModelState.IsValid) return BadRequest(ModelState);

    return Ok(product);
  }

  [HttpPost]
  public async Task<IActionResult> CreateProduct([FromBody] CreateProductRequest createdProduct)
  {
    if (createdProduct is null) return BadRequest(ModelState);
    if (!await _categoryService.CategoryExists(createdProduct.CategoryId)) return NotFound("Category not found");
    var category = _categoryService.GetCategory(createdProduct.CategoryId);
    var products = await _productService.GetProducts();
    var product = products.Where(u => u.Name.Trim().ToUpper() == createdProduct.Name.TrimEnd().ToUpper())
    .FirstOrDefault();

    if (product != null)
    {
      ModelState.AddModelError("", "Product already exists");
      return StatusCode(422, ModelState);
    }

    if (!ModelState.IsValid) return BadRequest(ModelState);

    var newProduct = _mapper.Map<Product>(createdProduct);

    if (!await _productService.CreateProduct(newProduct))
    {
      ModelState.AddModelError("", "Something went wrong while savin");
      return StatusCode(500, ModelState);
    }

    var createdProductResponse = _mapper.Map<CreateProductResponse>(newProduct);

    return Ok(createdProductResponse);
  }


  [HttpPut("{productId}")]
  public async Task<IActionResult> UpdateProduct([FromRoute] int productId, UpdateProductRequest updateProductRequest)
  {

    if (updateProductRequest == null)
      return BadRequest(ModelState);

    if (!await _productService.ProductExists(productId))
      return NotFound();
    if (!ModelState.IsValid)
      return BadRequest(ModelState);


    if (!await _productService.UpdateProduct(productId, updateProductRequest))
    {
      ModelState.AddModelError("", "Something went wrong updating product");
      return StatusCode(500, ModelState);
    }

    return NoContent();
  }


  [HttpDelete("{id}")]
  public async Task<IActionResult> DeleteProduct(int id)
  {
    var productToDelete = await _productService.GetProduct(id);
    if (productToDelete is null) return NotFound();
    await _productService.DeleteProduct(productToDelete);
    return NoContent();
  }

  [HttpPost("{productId}/favorites")]
  public async Task<IActionResult> AddAFavorite(CreateFavoriteRequest request)
  {
    if (request is null) return BadRequest(request);

    if (!await _userService.UserExists(request.UserId)) return NotFound("User does not exists");
    if (!await _productService.ProductExists(request.ProductId)) return NotFound("Product does not exists");

    if (!await _productService.AddProductToFavorites(request.UserId, request.ProductId))
    {
      ModelState.AddModelError("", "Something went wrong while adding a to favorites");
      return StatusCode(500, ModelState);
    }


    if (!ModelState.IsValid) return BadRequest(ModelState);

    return NoContent();
  }

  [HttpPost("{productId}/reviews")]
  public async Task<IActionResult> AddAReview([FromBody] CreateReviewRequest request)
  {
    if (request is null) return BadRequest(ModelState);

    var product = await _productService.GetProduct(request.ProductId);
    var user = await _userService.GetUser(request.UserId);
    if (product is null) return NotFound("Product does not exists");
    if (user is null) return NotFound("User does not exists");

    var newReview = _mapper.Map<Review>(request);

    if (!await _reviewService.CreateReview(newReview))
    {
      ModelState.AddModelError("", "Something went wrong while adding a review");
      return StatusCode(500, ModelState);
    }

    var createdReviewResponse = _mapper.Map<CreateReviewResponse>(newReview);

    if (!ModelState.IsValid) return BadRequest(ModelState);

    return Ok(createdReviewResponse);
  }

  [HttpGet("{productId}/reviews")]
  public async Task<IActionResult> GetReviews(int productId)
  {
    if (!await _productService.ProductExists(productId)) return NotFound();

    var reviewsMap = _mapper.Map<List<GetReviewResponse>>(await _productService.GetReviews(productId));

    if (!ModelState.IsValid) return BadRequest(ModelState);

    return Ok(reviewsMap);
  }

}