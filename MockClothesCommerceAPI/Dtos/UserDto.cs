namespace MockClothesCommerceAPI.Dtos;


public record CreateUserRequest
{
    public string Name { get; set; }
    public string Username { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
}


public record UpdateUserRequest
{

    public string Name { get; set; }
    public string Email { get; set; }
    public string? Password { get; set; }

}

