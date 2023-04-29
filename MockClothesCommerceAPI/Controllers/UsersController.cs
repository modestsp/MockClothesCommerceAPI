using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MockClothesCommerceAPI.Dtos;
using MockClothesCommerceAPI.Models;
using MockClothesCommerceAPI.Services.Product;
using MockClothesCommerceAPI.Services.User;

namespace MockClothesCommerceAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UsersController : ControllerBase
{
  private readonly IUserService _userService;
  private readonly IMapper _mapper;
  private readonly IProductService _productService;

  public UsersController(IUserService userService, IMapper mapper, IProductService productService)
  {
    _userService = userService;
    _mapper = mapper;
    _productService = productService;
  }

  [HttpGet]
  public async Task<IActionResult> GetUsers()
  {
    var users = await _userService.GetUsers();

    return Ok(users);
  }

  [HttpGet("{userId}")]
  [ProducesResponseType(404)]
  [ProducesResponseType(200)]
  public async Task<IActionResult> GetUser(int userId)
  {
    if (!await _userService.UserExists(userId)) return NotFound();

    var user = await _userService.GetUser(userId);

    return Ok(user);
  }

  [HttpGet("{userId}/favorites")]
  public async Task<IActionResult> GetFavoriteProducts(int userId)
  {
    if (!await _userService.UserExists(userId)) return NotFound("User does not found");

    var favorites = await _userService.Favorites(userId);

    if (!ModelState.IsValid) return BadRequest(ModelState);

    return Ok(favorites);
  }


  [HttpPost]
  public async Task<IActionResult> CreateUser([FromBody] CreateUserRequest request)
  {
    if (request is null) return BadRequest(ModelState);
    var users = await _userService.GetUsers();
    var user = users.Where(u => u.Username.Trim().ToUpper() == request.Username.TrimEnd().ToUpper())
        .FirstOrDefault();

    if (user != null)
    {
      ModelState.AddModelError("", "User already exists");
      return StatusCode(422, ModelState);
    }

    if (!ModelState.IsValid) return BadRequest(ModelState);

    var newUser = _mapper.Map<User>(request);

    if (!await _userService.CreateUser(newUser))
    {
      ModelState.AddModelError("", "Something went wrong while savin");
      return StatusCode(500, ModelState);
    }

    return Ok(newUser);
  }



  [HttpPut("{userId}")]
  public async Task<IActionResult> UpdateUser([FromRoute] int userId, UpdateUserRequest updateUserRequest)
  {

    if (updateUserRequest == null)
      return BadRequest(ModelState);

    if (!await _userService.UserExists(userId))
      return NotFound();
    if (!ModelState.IsValid)
      return BadRequest(ModelState);

    var updatedUser = await _userService.UpdateUser(userId, updateUserRequest);

    if (updatedUser is null)
    {
      ModelState.AddModelError("", "Something went wrong updating user");
      return StatusCode(500, ModelState);
    }

    return Ok(updatedUser);
  }


  [HttpDelete("{id}")]
  public async Task<IActionResult> DeleteUser(int id)
  {
    var userToDelete = await _userService.GetUser(id);
    if (userToDelete is null) return NotFound();
    await _userService.DeleteUser(userToDelete);
    return NoContent();
  }

  [HttpDelete("{userId}/favorites/{productId}")]
  public async Task<IActionResult> DeleteFavoriteProduct(DeleteFavoriteRequest request)
  {
    if (request is null) return BadRequest(request);

    if (!await _userService.UserExists(request.UserId)) return NotFound("User does not exists");
    if (!await _productService.ProductExists(request.ProductId)) return NotFound("Product does not exists");

    if (!await _productService.DeleteFavoriteProduct(request.UserId, request.ProductId))
    {
      ModelState.AddModelError("", "Something went wrong while adding a to favorites");
      return StatusCode(500, ModelState);
    }


    if (!ModelState.IsValid) return BadRequest(ModelState);

    return NoContent();
  }

  [HttpGet("{userId}/reviews")]
  public async Task<IActionResult> GetReviews(int userId)
  {

    if (!await _userService.UserExists(userId)) return NotFound("User not found");

    var reviews = _mapper.Map<List<GetReviewResponse>>(await _userService.GetReviews(userId));

    if (!ModelState.IsValid) return BadRequest(ModelState);

    return Ok(reviews);
  }

}

