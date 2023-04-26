
using MockClothesCommerceAPI.Dtos;

namespace MockClothesCommerceAPI.Services.Product;

public interface IProductService
{
    ICollection<Models.Product> GetProducts();
    bool CreateProduct(Models.Product product);
    Models.Product GetProduct(int id);
    bool UpdateProduct(int id, UpdateProductRequest product);
    bool AddProductToFavorites(int userId, int productId);
    bool AddReview(Models.Review newReview);
    bool DeleteProduct(Models.Product product);
    bool DeleteFavoriteProduct(int userId, int productId);
    ICollection<Models.Review> GetReviews(int productId);
    bool ProductExists(int id);
    bool Save();
}

