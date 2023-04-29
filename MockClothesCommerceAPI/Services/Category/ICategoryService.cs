using MockClothesCommerceAPI.Dtos;

namespace MockClothesCommerceAPI.Services.Category;

public interface ICategoryService
{
  Task<ICollection<Models.Category>> GetCategories();
  Task<Models.Category> GetCategory(int categoryId);
  Task<ICollection<Models.Product>> GetProductsFromCategory(int categoryId);
  Task<bool> CreateCategory(Models.Category category);
  Task<bool> UpdateCategory(int categoryId, UpdateCategoryRequest request);
  Task<bool> DeleteCategory(Models.Category category);
  Task<bool> CategoryExists(int categoryId);
  Task<bool> Save();
}

