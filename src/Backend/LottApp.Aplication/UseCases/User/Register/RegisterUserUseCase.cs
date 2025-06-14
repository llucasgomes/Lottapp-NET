using LottApp.Communication.Requests;
using LottApp.Communication.Responses;

namespace LottApp.Aplication.UseCases.User.Register;

public class RegisterUserUseCase
{
    public ResponseRegisterUserJson Execute(RequestRegisterUserJson user)
    {
        return new ResponseRegisterUserJson
        {
            UserId = Guid.NewGuid(),
            UserName = user.UserName,
        };
    }
}