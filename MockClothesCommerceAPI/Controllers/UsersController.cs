using Microsoft.AspNetCore.Mvc;
using MockClothesCommerceAPI.Contracts.User;

namespace MockClothesCommerceAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UsersController : ControllerBase
{
    [HttpPost]
    public IActionResult CreateUser(CreateUserRequest request)
    {
        return Ok(request);
    }

    [HttpGet("{id}")]
    public IActionResult GetUser(int id)
    {
        return Ok(id);
    }

}

