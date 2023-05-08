using Microsoft.EntityFrameworkCore;
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

    public async Task<bool> ProductExists(int id)
    {
        return await _context.Products.AnyAsync(p => p.Id == id);

    }
    /*Create a user*/
    public async Task<bool> CreateProduct(Models.Product product)
    {
        await _context.Products.AddAsync(product);
        return await Save();
    }

    /*Deletes a Product*/
    public async Task<bool> DeleteProduct(Models.Product Product)
    {
        _context.Products.Remove(Product);
        return await Save();
    }

    /*Get a single Product*/
    public async Task<Models.Product> GetProduct(int id)
    {
        var product = await _context.Products.FindAsync(id);
        var reviews = await _context.Reviews.Where(r => r.ProductId == id).ToListAsync();
        product.Stars = Models.Product.GetStars(reviews);

        return product;
    }

    /*Get a list of Products*/
    public async Task<ICollection<Models.Product>> GetProducts()
    {
        return await _context.Products.ToListAsync();
    }

    /*Updates a Product*/
    public async Task<Models.Product> UpdateProduct(int productId, UpdateProductRequest productUpdated)
    {
        var existingProduct = await _context.Products.FindAsync(productId);

        if (productUpdated.Name is not null) existingProduct.Name = productUpdated.Name;
        if (productUpdated.Description is not null) existingProduct.Description = productUpdated.Description;
        if (productUpdated.Price != existingProduct.Price) existingProduct.Price = productUpdated.Price;
        if (productUpdated.Tags is not null) existingProduct.Tags = productUpdated.Tags;

        await _context.SaveChangesAsync();

        return existingProduct;
    }


    public async Task<bool> AddReview(Models.Review newReview)
    {
        await _context.Reviews.AddAsync(newReview);
        return await Save();
    }

    public async Task<ICollection<Models.Review>> GetReviews(int productId)
    {
        return await _context.Reviews
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
            })
            .ToListAsync();
    }

    public async Task<bool> Save()
    {
        var saved = await _context.SaveChangesAsync();

        return saved > 0;
    }

    public async Task<bool> AddProductToFavorites(int userId, int productId)
    {
        var user = await _context.Users.FindAsync(userId);
        var product = await _context.Products.FindAsync(productId);

        var favoriteProduct = new FavoriteProduct
        {
            UserId = userId,
            ProductId = productId,
            User = user,
            Product = product
        };

        await _context.Favorites.AddAsync(favoriteProduct);

        return await Save();
    }

    public async Task<bool> DeleteFavoriteProduct(int userId, int productId)
    {
        var favoriteToDelete = await _context.Favorites
            .Where(fp => fp.UserId == userId && fp.ProductId == productId)
            .FirstOrDefaultAsync();
        _context.Favorites.Remove(favoriteToDelete);

        return await Save();
    }
}


