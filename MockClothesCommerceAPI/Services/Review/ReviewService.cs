using MockClothesCommerceAPI.Data;
using MockClothesCommerceAPI.Dtos;

namespace MockClothesCommerceAPI.Services.Review
{
    public class ReviewService : IReviewService
    {
        private readonly DataContext _context;

        public ReviewService(DataContext context)
        {
            _context = context;
        }

        public bool ReviewExists(int id)
        {
            return _context.Reviews.Any(u => u.Id == id);
        }
        /*Create a review*/
        public bool CreateReview(Models.Review review)
        {
            _context.Reviews.Add(review);
            return Save();
        }

        /*Deletes a review*/
        public bool DeleteReview(Models.Review review)
        {
            _context.Reviews.Remove(review);
            return Save();
        }

        /*Get a single review*/
        public Models.Review GetReview(int id)
        {
            return _context.Reviews.Find(id);
        }

        /*Get a list of reviews*/
        public ICollection<Models.Review> GetReviews()
        {
            return _context.Reviews.ToList();
        }

        /*Updates a review*/
        public bool UpdateReview(int reviewId, UpdateReviewRequest updateReviewRequest)
        {
            var existingReview = _context.Reviews.Find(reviewId);

            if (updateReviewRequest.Content is not null) existingReview!.Content = updateReviewRequest.Content;
            if (updateReviewRequest.Rating != existingReview!.Rating) existingReview.Rating = updateReviewRequest.Rating;

            existingReview.ModifiedAt = DateTime.UtcNow;
            return Save();
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();

            return saved > 0;
        }

    }
}
