namespace MeetingRoom.Application.DTOs.Responses;

public class UserResponse : BaseResponse
{
    public string Username { get; set; } = string.Empty;

    public bool IsAdmin { get; set; }
}
