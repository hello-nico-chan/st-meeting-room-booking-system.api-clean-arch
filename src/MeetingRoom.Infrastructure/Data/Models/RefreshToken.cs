namespace MeetingRoom.Infrastructure.Data.Models;

public class RefreshToken : ModelBase
{
    public Guid UserId { get; set; }

    public string Token { get; set; } = string.Empty;

    public DateTime LastRequestTime { get; set; }
}
