
using MockClothesCommerceAPI.Contracts.Product;

namespace MockClothesCommerceAPI.Services.Product;

public interface IProductService
{
    ICollection<Models.Product> GetProducts();
    bool CreateProduct(Models.Product product);
    Models.Product GetProduct(int id);
    bool UpdateProduct(int id, UpdateProductRequest product);
    bool DeleteProduct(Models.Product product);
    bool ProductExists(int id);
    bool Save();
}

