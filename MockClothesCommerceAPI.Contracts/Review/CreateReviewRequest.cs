namespace MockClothesCommerceAPI.Contracts.Review;

public record CreateReviewRequest(
    string Content,
    decimal Rating,
    int UserId,
    int ProductId);


