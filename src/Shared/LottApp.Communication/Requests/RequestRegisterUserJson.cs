namespace LottApp.Communication.Requests;

public class RequestRegisterUserJson
{
    public string UserName { get; set; }=string.Empty;
    public string Password { get; set; } = string.Empty;
}