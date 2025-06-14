using LottApp.Aplication.UseCases.User.Register;
using LottApp.Communication.Requests;
using LottApp.Communication.Responses;
using Microsoft.AspNetCore.Mvc;

namespace LottApp.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    [HttpPost]
    [ProducesResponseType(typeof(ResponseRegisterUserJson),StatusCodes.Status201Created)]
    public IActionResult Register([FromBody] RequestRegisterUserJson user)
    {
        var useCase = new RegisterUserUseCase();
        var response = useCase.Execute(user);
        return Created(String.Empty, response);
    }
}