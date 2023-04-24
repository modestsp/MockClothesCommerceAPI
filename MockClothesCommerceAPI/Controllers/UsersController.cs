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
    public IActionResult GetUsers()
    {
        var users = _userService.GetUsers();

        return Ok(users);
    }

    [HttpGet("{userId}")]
    [ProducesResponseType(404)]
    [ProducesResponseType(200)]
    public IActionResult GetUser(int userId)
    {
        if (!_userService.UserExists(userId)) return NotFound();

        var user = _userService.GetUser(userId);

        return Ok(user);
    }

    [HttpGet("{userId}/favorites")]
    public IActionResult GetFavoriteProducts(int userId)
    {
        if (!_userService.UserExists(userId)) return NotFound();

        var favorites = _userService.Favorites(userId);

        if (!ModelState.IsValid) return BadRequest(ModelState);

        return Ok(favorites);
    }


    [HttpPost]
    public IActionResult CreateUser([FromBody] CreateUserRequest request)
    {
        if (request is null) return BadRequest(ModelState);
        var user = _userService.GetUsers()
            .Where(u => u.Username.Trim().ToUpper() == request.Username.TrimEnd().ToUpper())
            .FirstOrDefault();

        if (user != null)
        {
            ModelState.AddModelError("", "User already exists");
            return StatusCode(422, ModelState);
        }

        if (!ModelState.IsValid) return BadRequest(ModelState);

        var newUser = _mapper.Map<User>(request);

        if (!_userService.CreateUser(newUser))
        {
            ModelState.AddModelError("", "Something went wrong while savin");
            return StatusCode(500, ModelState);
        }

        return Ok(newUser);
    }



    [HttpPut("{userId}")]
    public IActionResult UpdateUser([FromRoute] int userId, UpdateUserRequest updateUserRequest)
    {

        if (updateUserRequest == null)
            return BadRequest(ModelState);

        if (!_userService.UserExists(userId))
            return NotFound();
        if (!ModelState.IsValid)
            return BadRequest(ModelState);


        if (!_userService.UpdateUser(userId, updateUserRequest))
        {
            ModelState.AddModelError("", "Something went wrong updating user");
            return StatusCode(500, ModelState);
        }

        return NoContent();
    }


    [HttpDelete("{id}")]
    public IActionResult DeleteUser(int id)
    {
        var userToDelete = _userService.GetUser(id);
        if (userToDelete is null) return NotFound();
        _userService.DeleteUser(userToDelete);
        return NoContent();
    }

    [HttpDelete("{userId}/favorites/{productId}")]
    public IActionResult DeleteFavoriteProduct(DeleteFavoriteRequest request)
    {
        if (request is null) return BadRequest(request);

        if (!_userService.UserExists(request.UserId)) return NotFound("User does not exists");
        if (!_productService.ProductExists(request.ProductId)) return NotFound("Product does not exists");

        if (!_productService.DeleteFavoriteProduct(request.UserId, request.ProductId))
        {
            ModelState.AddModelError("", "Something went wrong while adding a to favorites");
            return StatusCode(500, ModelState);
        }


        if (!ModelState.IsValid) return BadRequest(ModelState);

        return NoContent();
    }

    [HttpGet("{userId}/reviews")]
    public IActionResult GetReviews(int userId)
    {

        if (!_userService.UserExists(userId)) return NotFound("User not found");

        var reviews = _mapper.Map<List<GetReviewResponse>>(_userService.GetReviews(userId));

        if (!ModelState.IsValid) return BadRequest(ModelState);

        return Ok(reviews);
    }

}

