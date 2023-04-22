namespace MockClothesCommerceAPI.Contracts.Review;

public record UpdateReviewRequest(
    string Content,
    decimal Rating,
    int UserId,
    int ProductId);

