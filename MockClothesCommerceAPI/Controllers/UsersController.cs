using Microsoft.AspNetCore.Mvc;
using MockClothesCommerceAPI.Contracts.User;
using MockClothesCommerceAPI.Models;
using MockClothesCommerceAPI.Services.User;

namespace MockClothesCommerceAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UsersController : ControllerBase
{
    private readonly IUserService _userService;

    public UsersController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpGet]
    public IActionResult GetUsers()
    {
        var users = _userService.GetUsers();

        return Ok(users);
    }

    [HttpGet("{id}")]
    [ProducesResponseType(404)]
    [ProducesResponseType(200)]
    public IActionResult GetUser(int userId)
    {
        if (!_userService.UserExists(userId)) return NotFound();

        var user = _userService.GetUser(userId);

        if (!ModelState.IsValid) return BadRequest(ModelState);

        return Ok(user);
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

        var newUser = new User
        {
            Username = request.Username,
            Name = request.Name,
            Email = request.Email,
            Password = request.Password,
            CreatedAt = DateTime.UtcNow,
            ModifiedAt = DateTime.UtcNow,
            Reviews = new List<Review>(),
        };

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

}

