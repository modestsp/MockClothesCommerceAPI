
using MockClothesCommerceAPI.Dtos;

namespace MockClothesCommerceAPI.Services.Review;

public interface IReviewService
{
  Task<ICollection<Models.Review>> GetReviews();
  Task<bool> CreateReview(Models.Review review);
  Task<Models.Review> GetReview(int id);
  Task<bool> UpdateReview(int reviewId, UpdateReviewRequest updatedReview);
  Task<bool> DeleteReview(Models.Review review);
  Task<bool> ReviewExists(int id);
  Task<bool> Save();
}

