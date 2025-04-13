using MeetingRoom.Application.DTOs.Requests;
using MeetingRoom.Application.DTOs.Responses;
using MeetingRoom.Application.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace MeetingRoom.Api.Controller;

[Route("api/[controller]")]
[ApiController]
public class BookingController : ControllerBase
{
    private readonly IBookingService _service;

    public BookingController(IBookingService service)
    {
        _service = service;
    }

    [HttpGet("list/{roomId}")]
    public async Task<ActionResult<List<BookingResponse>>> GetBookingsAsync(string roomId)
    {
        var bookings = await _service.GetBookingsAsync(roomId);
        return Ok(bookings);
    }

    [HttpPost]
    public async Task<ActionResult<BookingResponse>> BookingAsync(BookingRequest request)
    {
        try
        {
            await _service.CheckBooking(request.MeetingRoomId, request.StartTime, request.EndTime);
            var booking = await _service.BookingAsync(request.MeetingRoomId, request.UserId, request.Title, request.Participants, request.StartTime, request.EndTime);
            return Ok(booking);
        }
        catch (Exception ex)
        {
            if (ex.Message == "409") return Conflict();
            throw new Exception();
        }
    }

    [HttpDelete("{bookingId}")]
    public async Task<ActionResult> DeleteBookingAsync(string bookingId)
    {
        await _service.DeleteBookingAsync(bookingId);
        return Ok();
    }
}
