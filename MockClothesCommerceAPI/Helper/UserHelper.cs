using MockClothesCommerceAPI.Contracts.User;
using MockClothesCommerceAPI.Models;

namespace MockClothesCommerceAPI.Helper;

public class UserHelper
{
    public static CreateUserResponse MapCreateUserResponse(User user)
    {
        return new CreateUserResponse(
            user.Id,
            user.Name,
            user.Username,
            user.Email,
            user.CreatedAt,
            user.ModifiedAt);
    }

    public static GetUserResponse MapGetUserResponse(User user)
    {
        return new GetUserResponse(
            user.Id,
            user.Name,
            user.Username,
            user.Email,
            user.CreatedAt,
            user.ModifiedAt);
    }
}

