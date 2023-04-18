namespace MockClothesCommerceAPI.Contracts.User;

public record UserResponse(
    int Id,
    string Name,
    string Username,
    string Email,
    DateTime CreatedAt,
    DateTime ModifiedAt);

