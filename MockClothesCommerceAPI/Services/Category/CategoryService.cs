using MockClothesCommerceAPI.Contracts.Category;
using MockClothesCommerceAPI.Data;

namespace MockClothesCommerceAPI.Services.Category;


public class CategoryService : ICategoryService
{
    private readonly DataContext _context;

    public CategoryService(DataContext context)
    {
        _context = context;
    }

    public bool CategoryExists(int id)
    {
        return _context.Categories.Any(u => u.Id == id);
    }
    /*Create a category*/
    public bool CreateCategory(Models.Category category)
    {
        _context.Categories.Add(category);
        return Save();
    }

    /*Deletes a category*/
    public bool DeleteCategory(Models.Category category)
    {
        _context.Categories.Remove(category);
        return Save();
    }

    /*Get a single category*/
    public Models.Category GetCategory(int categoryId)
    {
        return _context.Categories.Find(categoryId);
    }

    /*Get a list of categories*/
    public ICollection<Models.Category> GetCategories()
    {
        var categorys = _context.Categories.ToList();
        return categorys;
    }

    /*Updates a category*/
    public bool UpdateCategory(int categoryId, UpdateCategoryRequest categoryUpdated)
    {
        var existingCategory = _context.Categories.Find(categoryId);

        if (categoryUpdated.Name is not null) existingCategory.Name = categoryUpdated.Name;

        return Save();
    }

    public bool Save()
    {
        var saved = _context.SaveChanges();

        return saved > 0;
    }


}


