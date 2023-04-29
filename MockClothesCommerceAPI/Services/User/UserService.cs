using Microsoft.EntityFrameworkCore;
using MockClothesCommerceAPI.Data;
using MockClothesCommerceAPI.Dtos;
using MockClothesCommerceAPI.Models;

namespace MockClothesCommerceAPI.Services.User
{
  public class UserService : IUserService
  {
    private readonly DataContext _context;

    public UserService(DataContext context)
    {
      _context = context;
    }

    public async Task<bool> UserExists(int id)
    {
      return await _context.Users.AnyAsync(u => u.Id == id);
    }
    /*Create a user*/
    public async Task<bool> CreateUser(Models.User user)
    {
      await _context.Users.AddAsync(user);
      return await Save();
    }

    /*Deletes a user*/
    public async Task<bool> DeleteUser(Models.User user)
    {
      _context.Users.Remove(user);
      return await Save();
    }

    /*Get a single user*/
    public async Task<Models.User> GetUser(int id)
    {
      return await _context.Users.FindAsync(id);
    }

    /*Get a list of users*/
    public async Task<ICollection<Models.User>> GetUsers()
    {
      return await _context.Users.ToListAsync();
    }

    /*Updates a user*/
    public async Task<Models.User> UpdateUser(int userId, UpdateUserRequest userUpdated)
    {
      var existingUser = await _context.Users.FindAsync(userId);

      if (userUpdated.Name is not null) existingUser.Name = userUpdated.Name;
      if (userUpdated.Email is not null) existingUser.Email = userUpdated.Email;
      if (userUpdated.Password is not null) existingUser.Password = userUpdated.Password;

      await _context.SaveChangesAsync();

      return existingUser;

    }

    public async Task<ICollection<Models.Review>> GetReviews(int userId)
    {
      return await _context.Reviews
          .Where(r => r.UserId == userId)
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

    public async Task<ICollection<FavoriteProduct>> Favorites(int userId)
    {
      return await _context.Favorites
          .Where(f => f.UserId == userId)
          .Include(f => f.Product)
          .ToListAsync();
    }
  }
}
