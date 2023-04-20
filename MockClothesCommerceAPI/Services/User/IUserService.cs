using MockClothesCommerceAPI.Contracts.User;

namespace MockClothesCommerceAPI.Services.User;

public interface IUserService
{
    ICollection<Models.User> GetUsers();
    bool CreateUser(Models.User user);
    Models.User GetUser(int id);
    bool UpdateUser(int id, UpdateUserRequest user);
    bool DeleteUser(Models.User user);
    bool UserExists(int id);
    bool Save();
    //UserResponse UpdateUser(UpdateUserRequest request);
    //ICollection<UserResponse> GetUsers();
}

