
using MockClothesCommerceAPI.Dtos;

namespace MockClothesCommerceAPI.Services.Product;

public interface IProductService
{
  Task<ICollection<Models.Product>> GetProducts();
  Task<bool> CreateProduct(Models.Product product);
  Task<Models.Product> GetProduct(int id);
  Task<bool> UpdateProduct(int id, UpdateProductRequest product);
  Task<bool> AddProductToFavorites(int userId, int productId);
  Task<bool> AddReview(Models.Review newReview);
  Task<bool> DeleteProduct(Models.Product product);
  Task<bool> DeleteFavoriteProduct(int userId, int productId);
  Task<ICollection<Models.Review>> GetReviews(int productId);
  Task<bool> ProductExists(int id);
  Task<bool> Save();
}

