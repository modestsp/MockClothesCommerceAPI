using MockClothesCommerceAPI.Data;
using MockClothesCommerceAPI.Dtos;
using MockClothesCommerceAPI.Models;

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
    public bool CreateProduct(Models.Product product)
    {
        _context.Products.Add(product);
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
        return _context.Products.FirstOrDefault();
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

        return Save();
    }


    public bool AddReview(Models.Review newReview)
    {
        _context.Reviews.Add(newReview);
        return Save();
    }

    public ICollection<Models.Review> GetReviews(int productId)
    {
        var reviews = _context.Reviews
            .Where(r => r.ProductId == productId)
            .Select(r => new Models.Review
            {
                Id = r.Id,
                Content = r.Content,
                Rating = r.Rating,
                CreatedAt = r.CreatedAt,
                ModifiedAt = r.ModifiedAt,
                User = new Models.User
                {
                    Id = r.User.Id,
                    Username = r.User.Username,
                },
                Product = new Models.Product
                {
                    Id = r.Product.Id,
                    Name = r.Product.Name,
                }
            });

        return reviews.ToList();
    }

    public bool Save()
    {
        var saved = _context.SaveChanges();

        return saved > 0;
    }

    public bool AddProductToFavorites(int userId, int productId)
    {
        var user = _context.Users.Find(userId);
        var product = _context.Products.Find(productId);

        var favoriteProduct = new FavoriteProduct
        {
            UserId = userId,
            ProductId = productId,
            User = user,
            Product = product
        };

        _context.Favorites.Add(favoriteProduct);

        return Save();
    }

    public bool DeleteFavoriteProduct(int userId, int productId)
    {
        var favoriteToDelete = _context.Favorites
            .Where(fp => fp.UserId == userId && fp.ProductId == productId)
            .FirstOrDefault();
        _context.Favorites.Remove(favoriteToDelete);

        return Save();
    }
}


