using MeetingRoom.Application.DTOs.Requests;
using MeetingRoom.Application.DTOs.Responses;
using MeetingRoom.Application.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace MeetingRoom.Api.Controller;

[Route("api/[controller]")]
[ApiController]
public class MeetingRoomController : ControllerBase
{
    private readonly IMeetingRoomService _service;

    public MeetingRoomController(IMeetingRoomService service)
    {
        _service = service;
    }

    [HttpPost]
    public async Task<ActionResult> AddMeetingRoomAsync(AddMeetingRoomRequest request)
    {
        var meetingRoom = await _service.AddMeetingRoomAsync(request.Name, request.Location, request.Capacity, request.Type, request.Remark);
        return Ok(meetingRoom);
    }

    [HttpPut]
    public async Task<ActionResult<MeetingRoomResponse>> EditMeetingRoomAsync(EditMeetingRoomRequest request)
    {
        var meetingroom = await _service.EditMeetingRoomAsync(request.Id, request.Name, request.Location, request.Capacity, request.Type, request.Remark);
        return Ok(meetingroom);
    }

    [HttpGet("list")]
    public async Task<ActionResult<List<MeetingRoomResponse>>> GetMeetingRoomsAsync()
    {
        var meetingRooms = await _service.GetAllMeetingRoomsAsync();
        return Ok(meetingRooms);
    }

    [HttpGet("{roomId}")]
    public async Task<ActionResult<MeetingRoomResponse>> GetMeetingRoomAsync(string roomId)
    {
        var meetingRoom = await _service.GetMeetingRoomByIdAsync(roomId);
        return Ok(meetingRoom);
    }

    [HttpDelete("{roomId}")]
    public async Task<ActionResult> DeleteMeetingRoomAsync(string roomId)
    {
        await _service.DeleteMeetingRoomByIdAsync(roomId);
        return Ok();
    }
}
