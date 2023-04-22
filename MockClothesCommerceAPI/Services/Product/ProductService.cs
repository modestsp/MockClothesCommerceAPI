using MockClothesCommerceAPI.Contracts.Product;
using MockClothesCommerceAPI.Data;

namespace MockClothesCommerceAPI.Services.Product;

public class ProductService : IProductService
{
    private readonly DataContext _context;

    public ProductService(DataContext context)
    {
        _context = context;
    }

    public bool ProductExists(int id)
    {
        return _context.Products.Any(u => u.Id == id);
    }
    /*Create a user*/
    public bool CreateProduct(Models.Product Product)
    {
        _context.Products.Add(Product);
        return Save();
    }

    /*Deletes a Product*/
    public bool DeleteProduct(Models.Product Product)
    {
        _context.Products.Remove(Product);
        return Save();
    }

    /*Get a single Product*/
    public Models.Product GetProduct(int id)
    {
        return _context.Products.Find(id);
    }

    /*Get a list of Products*/
    public ICollection<Models.Product> GetProducts()
    {
        return _context.Products.ToList();
    }

    /*Updates a Product*/
    public bool UpdateProduct(int productId, UpdateProductRequest productUpdated)
    {
        var existingProduct = _context.Products.Find(productId);

        if (productUpdated.Name is not null) existingProduct.Name = productUpdated.Name;
        if (productUpdated.Description is not null) existingProduct.Description = productUpdated.Description;
        if (productUpdated.Price != existingProduct.Price) existingProduct.Price = productUpdated.Price;
        if (productUpdated.Tags is not null) existingProduct.Tags = productUpdated.Tags;
        // Ver que onda la lista de tags

        return Save();
    }

    public bool Save()
    {
        var saved = _context.SaveChanges();

        return saved > 0;
    }

}


