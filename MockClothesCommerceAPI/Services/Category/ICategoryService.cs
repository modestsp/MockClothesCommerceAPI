using MockClothesCommerceAPI.Dtos;

namespace MockClothesCommerceAPI.Services.Category;

public interface ICategoryService
{
    ICollection<Models.Category> GetCategories();
    Models.Category GetCategory(int categoryId);
    ICollection<Models.Product> GetProductsFromCategory(int categoryId);
    bool CreateCategory(Models.Category category);
    bool UpdateCategory(int categoryId, UpdateCategoryRequest request);
    bool DeleteCategory(Models.Category category);
    bool CategoryExists(int categoryId);
    bool Save();
}

