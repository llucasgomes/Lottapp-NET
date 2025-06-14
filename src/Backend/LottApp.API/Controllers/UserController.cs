using Microsoft.AspNetCore.Mvc;

namespace LottApp.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    [HttpGet]
    [ProducesResponseType(typeof(string),StatusCodes.Status201Created)]
    public IActionResult Register()
    {
        return Created(String.Empty, "Register");
    }
}