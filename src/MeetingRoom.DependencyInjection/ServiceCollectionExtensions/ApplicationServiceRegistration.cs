using MeetingRoom.Application.Interfaces.Services;
using MeetingRoom.Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;

namespace MeetingRoom.DependencyInjection.ServiceCollectionExtensions;

public static class ApplicationServiceRegistration
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddScoped<IBookingService, BookingService>();
        services.AddScoped<IMeetingRoomService, MeetingRoomService>();
        services.AddScoped<ITokenService, TokenService>();
        services.AddScoped<IUserService, UserService>();
        return services;
    }

}
