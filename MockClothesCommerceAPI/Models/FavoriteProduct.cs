namespace MockClothesCommerceAPI.Models;

public class FavoriteProduct
{
    public int UserId { get; }
    public int ProductId { get; }
    public User User { get; }
    public Product Product { get; }
}

