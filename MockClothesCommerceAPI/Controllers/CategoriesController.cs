using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MockClothesCommerceAPI.Dtos;
using MockClothesCommerceAPI.Models;
using MockClothesCommerceAPI.Services.Category;

namespace MockClothesCommerceAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CategoriesController : ControllerBase
{
  private readonly ICategoryService _categoryService;
  private readonly IMapper _mapper;

  public CategoriesController(ICategoryService categoryService,
      IMapper mapper)
  {
    _categoryService = categoryService;
    _mapper = mapper;
  }

  [HttpGet]
  public async Task<IActionResult> GetCategories()
  {
    var categories = await _categoryService.GetCategories();

    return Ok(categories);
  }

  [HttpGet("{categoryId}")]
  [ProducesResponseType(404)]
  [ProducesResponseType(200)]
  public async Task<IActionResult> GetCategory(int categoryId)
  {
    if (!await _categoryService.CategoryExists(categoryId)) return NotFound();

    var category = _mapper.Map<GetCategoryResponse>(await _categoryService.GetCategory(categoryId));
    //var category = await _categoryService.GetCategory(categoryId);
    if (!ModelState.IsValid) return BadRequest(ModelState);

    return Ok(category);
  }

  [HttpPost]
  public async Task<IActionResult> CreateCategory([FromBody] CreateCategoryRequest request)
  {
    if (request is null) return BadRequest(ModelState);
    var categories = await _categoryService.GetCategories();
    var category = categories.Where(u => u.Name.Trim().ToUpper() == request.Name.TrimEnd().ToUpper())
    .FirstOrDefault();

    if (category != null)
    {
      ModelState.AddModelError("", "Category already exists");
      return StatusCode(422, ModelState);
    }

    if (!ModelState.IsValid) return BadRequest(ModelState);

    var newCategory = new Category
    {
      Name = request.Name,
      CreatedAt = DateTime.UtcNow,
      ModifiedAt = DateTime.UtcNow,
    };

    if (!await _categoryService.CreateCategory(newCategory))
    {
      ModelState.AddModelError("", "Something went wrong while savin");
      return StatusCode(500, ModelState);
    }

    return Ok(newCategory);
  }



  [HttpPut("{categoryId}")]
  public async Task<IActionResult> UpdateCategory([FromRoute] int categoryId, UpdateCategoryRequest updateCategoryRequest)
  {

    if (updateCategoryRequest == null)
      return BadRequest(ModelState);

    if (!await _categoryService.CategoryExists(categoryId))
      return NotFound();
    if (!ModelState.IsValid)
      return BadRequest(ModelState);


    if (!await _categoryService.UpdateCategory(categoryId, updateCategoryRequest))
    {
      ModelState.AddModelError("", "Something went wrong updating category");
      return StatusCode(500, ModelState);
    }

    return NoContent();
  }


  [HttpDelete("{id}")]
  public async Task<IActionResult> DeleteCategory(int id)
  {
    var categoryToDelete = await _categoryService.GetCategory(id);
    if (categoryToDelete is null) return NotFound();
    await _categoryService.DeleteCategory(categoryToDelete);
    return NoContent();
  }

  [HttpGet("{categoryId}/products")]
  public async Task<IActionResult> GetProductsFromCategory(int categoryId)
  {

    if (!await _categoryService.CategoryExists(categoryId)) return NotFound("Category not found");

    var products = _mapper.Map<List<GetProductResponse>>(await _categoryService.GetProductsFromCategory(categoryId));

    if (!ModelState.IsValid) return BadRequest(ModelState);

    return Ok(products);
  }

}
