using ErrorOr;
using MockClothesCommerceAPI.Contracts.User;

namespace MockClothesCommerceAPI.Services.User;

public interface IUserService
{
    ICollection<Models.User> GetUsers();
    void CreateUser(Models.User user);
    ErrorOr<Models.User> GetUser(int id);
    Task UpdateUser(int id, UpdateUserRequest updateUserRequest);
    void DeleteUser(int id);

    //UserResponse UpdateUser(UpdateUserRequest request);
    //ICollection<UserResponse> GetUsers();
}

