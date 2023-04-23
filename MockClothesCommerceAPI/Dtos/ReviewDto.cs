namespace MockClothesCommerceAPI.Dtos;

public class CreateReviewRequest
{
    public string Content { get; set; }
    public decimal Rating { get; set; }
    public int UserId { get; set; }
    public int ProductId { get; set; }
}
public class CreateReviewResponse
{
    public int Id { get; set; }
    public string Content { get; set; }
    public decimal Rating { get; set; }
    public int UserId { get; set; }
    public int ProductId { get; set; }
}

public class UpdateReviewRequest
{
    public string Content { get; set; }
    public decimal Rating { get; set; }
    public int UserId { get; set; }
    public int ProductId { get; set; }
}
public class GetReviewResponse
{
    public int Id { get; set; }
    public string Content { get; set; }
    public decimal Rating { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime ModifiedAt { get; set; }
    public string Username { get; set; }
    public int UserId { get; set; }
    public string ProductName { get; set; }
    public int ProductId { get; set; }
}
