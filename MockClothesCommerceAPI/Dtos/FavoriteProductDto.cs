namespace MockClothesCommerceAPI.Dtos;
public class CreateFavoriteRequest
{
    public int UserId { get; set; }
    public int ProductId { get; set; }
}

public class DeleteFavoriteRequest
{
    public int UserId { get; set; }
    public int ProductId { get; set; }
}
