using MeetingRoom.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace MeetingRoom.Infrastructure.Data;

public class MrbsDbContext : DbContext
{
    public DbSet<Booking> Bookings { get; set; }
    public DbSet<Models.MeetingRoom> MeetingRooms { get; set; }
    public DbSet<RefreshToken> RefreshTokens { get; set; }
    public DbSet<User> Users { get; set; }

    public MrbsDbContext(DbContextOptions<MrbsDbContext> options) : base(options)
    {

    }
}
