namespace MeetingRoom.Application.DTOs.Requests;

public class EditMeetingRoomRequest
{
    public string Id { get; set; } = string.Empty;

    public string Name { get; set; } = string.Empty;

    public string Location { get; set; } = string.Empty;

    public int Capacity { get; set; }

    public string Type { get; set; } = string.Empty;

    public string Remark { get; set; } = string.Empty;
}
