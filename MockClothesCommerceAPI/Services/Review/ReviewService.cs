using Microsoft.EntityFrameworkCore;
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

    public async Task<bool> ReviewExists(int id)
    {
      return await _context.Reviews.AnyAsync(u => u.Id == id);
    }
    /*Create a review*/
    public async Task<bool> CreateReview(Models.Review review)
    {
      await _context.Reviews.AddAsync(review);
      return await Save();
    }

    /*Deletes a review*/
    public async Task<bool> DeleteReview(Models.Review review)
    {
      _context.Reviews.Remove(review);
      return await Save();
    }

    /*Get a single review*/
    public async Task<Models.Review> GetReview(int id)
    {
      return await _context.Reviews.FindAsync(id);
    }

    /*Get a list of reviews*/
    public async Task<ICollection<Models.Review>> GetReviews()
    {
      return await _context.Reviews.ToListAsync();
    }

    /*Updates a review*/
    public async Task<bool> UpdateReview(int reviewId, UpdateReviewRequest updateReviewRequest)
    {
      var existingReview = await _context.Reviews.FindAsync(reviewId);

      if (updateReviewRequest.Content is not null) existingReview!.Content = updateReviewRequest.Content;
      if (updateReviewRequest.Rating != existingReview!.Rating) existingReview.Rating = updateReviewRequest.Rating;

      existingReview.ModifiedAt = DateTime.UtcNow;
      return await Save();
    }

    public async Task<bool> Save()
    {
      var saved = await _context.SaveChangesAsync();

      return saved > 0;
    }

  }
}
