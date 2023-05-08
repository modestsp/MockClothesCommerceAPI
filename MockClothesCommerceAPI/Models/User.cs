using System.ComponentModel.DataAnnotations;
namespace MockClothesCommerceAPI.Models;

public class User
{
    public const int MinUsernameLength = 3;
    public const int MaxUsernameLength = 20;

    public int Id { get; set; }
    public string Username { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    // Check for confirmPassword
    public string Password { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime ModifiedAt { get; set; } = DateTime.Now;

}

