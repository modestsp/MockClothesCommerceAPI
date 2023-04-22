using Microsoft.AspNetCore.Mvc;
using MockClothesCommerceAPI.Contracts.Category;
using MockClothesCommerceAPI.Models;
using MockClothesCommerceAPI.Services.Category;

namespace MockClothesCommerceAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CategoriesController : ControllerBase
{
    private readonly ICategoryService _categoryService;

    public CategoriesController(ICategoryService categoryService)
    {
        _categoryService = categoryService;
    }

    [HttpGet]
    public IActionResult GetCategories()
    {
        var categories = _categoryService.GetCategories();

        return Ok(categories);
    }

    [HttpGet("{categoryId}")]
    [ProducesResponseType(404)]
    [ProducesResponseType(200)]
    public IActionResult GetCategory(int categoryId)
    {
        if (!_categoryService.CategoryExists(categoryId)) return NotFound();

        var category = _categoryService.GetCategory(categoryId);

        if (!ModelState.IsValid) return BadRequest(ModelState);

        return Ok(category);
    }

    [HttpPost]
    public IActionResult CreateCategory([FromBody] CreateCategoryRequest request)
    {
        if (request is null) return BadRequest(ModelState);
        var category = _categoryService.GetCategories()
            .Where(u => u.Name.Trim().ToUpper() == request.Name.TrimEnd().ToUpper())
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
            Products = new List<Product>(),
        };

        if (!_categoryService.CreateCategory(newCategory))
        {
            ModelState.AddModelError("", "Something went wrong while savin");
            return StatusCode(500, ModelState);
        }

        return Ok(newCategory);
    }



    [HttpPut("{categoryId}")]
    public IActionResult UpdateCategory([FromRoute] int categoryId, UpdateCategoryRequest updateCategoryRequest)
    {

        if (updateCategoryRequest == null)
            return BadRequest(ModelState);

        if (!_categoryService.CategoryExists(categoryId))
            return NotFound();
        if (!ModelState.IsValid)
            return BadRequest(ModelState);


        if (!_categoryService.UpdateCategory(categoryId, updateCategoryRequest))
        {
            ModelState.AddModelError("", "Something went wrong updating category");
            return StatusCode(500, ModelState);
        }

        return NoContent();
    }


    [HttpDelete("{id}")]
    public IActionResult DeleteCategory(int id)
    {
        var categoryToDelete = _categoryService.GetCategory(id);
        if (categoryToDelete is null) return NotFound();
        _categoryService.DeleteCategory(categoryToDelete);
        return NoContent();
    }

}
