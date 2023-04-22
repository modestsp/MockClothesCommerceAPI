using Microsoft.AspNetCore.Mvc;
using MockClothesCommerceAPI.Contracts.Review;
using MockClothesCommerceAPI.Models;
using MockClothesCommerceAPI.Services.Review;

namespace MockClothesCommerceAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ReviewsController : ControllerBase
{
    private readonly IReviewService _reviewService;

    public ReviewsController(IReviewService reviewService)
    {
        _reviewService = reviewService;
    }

    [HttpGet]
    public IActionResult GetReviews()
    {
        var reviews = _reviewService.GetReviews();

        return Ok(reviews);
    }

    [HttpGet("{reviewId}")]
    [ProducesResponseType(404)]
    [ProducesResponseType(200)]
    public IActionResult GetReview(int reviewId)
    {
        if (!_reviewService.ReviewExists(reviewId)) return NotFound();

        var review = _reviewService.GetReview(reviewId);

        if (!ModelState.IsValid) return BadRequest(ModelState);

        return Ok(review);
    }

    [HttpPost]
    public IActionResult CreateReview([FromBody] CreateReviewRequest request)
    {
        if (request is null) return BadRequest(ModelState);

        if (!ModelState.IsValid) return BadRequest(ModelState);

        var newReview = new Review
        {
            Content = request.Content,
            Rating = request.Rating,
            UserId = request.UserId,
            ProductId = request.ProductId,
            CreatedAt = DateTime.UtcNow,
            ModifiedAt = DateTime.UtcNow
        };

        if (!_reviewService.CreateReview(newReview))
        {
            ModelState.AddModelError("", "Something went wrong while savin");
            return StatusCode(500, ModelState);
        }

        return Ok(newReview);
    }

    [HttpPut("{reviewId}")]
    public IActionResult UpdateReview([FromRoute] int reviewId, UpdateReviewRequest updateReviewRequest)
    {

        if (updateReviewRequest == null)
            return BadRequest(ModelState);

        if (!_reviewService.ReviewExists(reviewId))
            return NotFound();

        var existingReview = _reviewService.GetReview(reviewId);

        if (existingReview.UserId != updateReviewRequest.UserId) return Unauthorized();
        if (existingReview.ProductId != updateReviewRequest.ProductId) return BadRequest();
        if (!ModelState.IsValid)
            return BadRequest(ModelState);


        if (!_reviewService.UpdateReview(reviewId, updateReviewRequest))
        {
            ModelState.AddModelError("", "Something went wrong updating review");
            return StatusCode(500, ModelState);
        }

        return NoContent();
    }



    [HttpDelete("{id}")]
    public IActionResult DeleteReview(int id)
    {
        var reviewToDelete = _reviewService.GetReview(id);
        if (reviewToDelete is null) return NotFound();
        _reviewService.DeleteReview(reviewToDelete);
        return NoContent();
    }

}

