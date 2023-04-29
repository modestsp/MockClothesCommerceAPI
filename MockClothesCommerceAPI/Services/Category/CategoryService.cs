using Microsoft.EntityFrameworkCore;
using MockClothesCommerceAPI.Data;
using MockClothesCommerceAPI.Dtos;

namespace MockClothesCommerceAPI.Services.Category;


public class CategoryService : ICategoryService
{
  private readonly DataContext _context;

  public CategoryService(DataContext context)
  {
    _context = context;
  }

  public async Task<bool> CategoryExists(int id)
  {
    return await _context.Categories.AnyAsync(u => u.Id == id);
  }
  /*Create a category*/
  public async Task<bool> CreateCategory(Models.Category category)
  {
    _context.Categories.Add(category);
    return await Save();
  }

  /*Deletes a category*/
  public async Task<bool> DeleteCategory(Models.Category category)
  {
    _context.Categories.Remove(category);
    return await Save();
  }

  /*Get a single category*/
  public async Task<Models.Category> GetCategory(int categoryId)
  {
    return await _context.Categories.FirstOrDefaultAsync(c => c.Id == categoryId);
  }

  public async Task<ICollection<Models.Product>> GetProductsFromCategory(int categoryId)
  {
    return await _context.Products
        .Where(p => p.CategoryId == categoryId).ToListAsync();

  }

  /*Get a list of categories*/
  public async Task<ICollection<Models.Category>> GetCategories()
  {
    return await _context.Categories.ToListAsync();
  }

  /*Updates a category*/
  public async Task<bool> UpdateCategory(int categoryId, UpdateCategoryRequest categoryUpdated)
  {
    var existingCategory = await _context.Categories.FindAsync(categoryId);

    if (categoryUpdated.Name is not null) existingCategory.Name = categoryUpdated.Name;

    return await Save();
  }

  public async Task<bool> Save()
  {
    var saved = _context.SaveChangesAsync();

    return await saved > 0;
  }


}


