namespace MeetingRoom.Domain.Entities;

public class UserModel : BaseModel
{
    public string Username { get; set; } = string.Empty;

    public string Password { get; set; } = string.Empty;

    public bool IsAdmin { get; set; }
}
