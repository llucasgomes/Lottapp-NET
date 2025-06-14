namespace LottApp.Communication.Responses;

public class ResponseRegisterUserJson
{
    public Guid UserId { get; set; } = Guid.Empty;
    public string UserName { get; set; } = string.Empty;
    
}