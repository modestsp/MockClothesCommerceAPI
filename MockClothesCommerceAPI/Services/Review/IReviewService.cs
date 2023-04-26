
using MockClothesCommerceAPI.Dtos;

namespace MockClothesCommerceAPI.Services.Review;

public interface IReviewService
{
    ICollection<Models.Review> GetReviews();
    bool CreateReview(Models.Review review);
    Models.Review GetReview(int id);
    bool UpdateReview(int reviewId, UpdateReviewRequest updatedReview);
    bool DeleteReview(Models.Review review);
    bool ReviewExists(int id);
    bool Save();
}

