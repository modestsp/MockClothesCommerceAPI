using MockClothesCommerceAPI.Dtos;

namespace MockClothesCommerceAPI.Services.User;

public interface IUserService
{
    ICollection<Models.User> GetUsers();
    bool CreateUser(Models.User user);
    Models.User GetUser(int id);
    ICollection<Models.Review> GetReviews(int userId);
    bool UpdateUser(int id, UpdateUserRequest user);
    bool DeleteUser(Models.User user);
    bool UserExists(int id);
    ICollection<Models.FavoriteProduct> Favorites(int userId);
    bool Save();
    //UserResponse UpdateUser(UpdateUserRequest request);
    //ICollection<UserResponse> GetUsers();
}

