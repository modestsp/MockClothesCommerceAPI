namespace MockClothesCommerceAPI.Contracts.User;

public record CreateUserRequest(
    string Name,
    string Username,
    string Email,
    string Password);

