using Microsoft.AspNetCore.Mvc;
using MockClothesCommerceAPI.Dtos;
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
  public async Task<IActionResult> GetReviews()
  {
    var reviews = _reviewService.GetReviews();

    return Ok(reviews);
  }

  [HttpGet("{reviewId}")]
  [ProducesResponseType(404)]
  [ProducesResponseType(200)]
  public async Task<IActionResult> GetReview(int reviewId)
  {
    if (!await _reviewService.ReviewExists(reviewId)) return NotFound();

    var review = await _reviewService.GetReview(reviewId);

    if (!ModelState.IsValid) return BadRequest(ModelState);

    return Ok(review);
  }

  // [HttpPost]
  //  public async Task<IActionResult> CreateReview([FromBody] CreateReviewRequest request)
  //  {
  //     if (request is null) return BadRequest(ModelState);

  //     if (!ModelState.IsValid) return BadRequest(ModelState);

  //    var newReview = new Review
  //     {
  //         Content = request.Content,
  //         Rating = request.Rating,
  //        UserId = request.UserId,
  //  ProductId = request.ProductId,
  //        CreatedAt = DateTime.UtcNow,
  //        ModifiedAt = DateTime.UtcNow
  //    };

  //    if (!await _reviewService.CreateReview(newReview))
  //    {
  //       ModelState.AddModelError("", "Something went wrong while savin");
  //        return StatusCode(500, ModelState);
  //   }

  //    return Ok(newReview);
  //   }

  [HttpPut("{reviewId}")]
  public async Task<IActionResult> UpdateReview([FromRoute] int reviewId, UpdateReviewRequest updateReviewRequest)
  {

    if (updateReviewRequest == null)
      return BadRequest(ModelState);

    if (!await _reviewService.ReviewExists(reviewId))
      return NotFound();

    var existingReview = await _reviewService.GetReview(reviewId);

    if (existingReview.UserId != updateReviewRequest.UserId) return Unauthorized();
    if (existingReview.ProductId != updateReviewRequest.ProductId) return BadRequest();
    if (!ModelState.IsValid)
      return BadRequest(ModelState);


    if (!await _reviewService.UpdateReview(reviewId, updateReviewRequest))
    {
      ModelState.AddModelError("", "Something went wrong updating review");
      return StatusCode(500, ModelState);
    }

    return NoContent();
  }



  [HttpDelete("{id}")]
  public async Task<IActionResult> DeleteReview(int id)
  {
    var reviewToDelete = await _reviewService.GetReview(id);
    if (reviewToDelete is null) return NotFound();
    await _reviewService.DeleteReview(reviewToDelete);
    return NoContent();
  }

}

