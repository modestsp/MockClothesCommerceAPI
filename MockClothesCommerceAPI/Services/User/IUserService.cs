using MockClothesCommerceAPI.Dtos;

namespace MockClothesCommerceAPI.Services.User;

public interface IUserService
{
  Task<ICollection<Models.User>> GetUsers();
  Task<bool> CreateUser(Models.User user);
  Task<Models.User> GetUser(int id);
  Task<ICollection<Models.Review>> GetReviews(int userId);
  Task<Models.User> UpdateUser(int id, UpdateUserRequest user);
  Task<bool> DeleteUser(Models.User user);
  Task<bool> UserExists(int id);
  Task<ICollection<Models.FavoriteProduct>> Favorites(int userId);
  Task<bool> Save();
}

