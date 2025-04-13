using MeetingRoom.Application.Interfaces.Repositories;
using MeetingRoom.Infrastructure.Data;
using MeetingRoom.Infrastructure.Data.Models;
using MeetingRoom.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MeetingRoom.DependencyInjection.ServiceCollectionExtensions;

public static class InfrastructureServiceRegistration
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<MrbsDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("MrbsConnectionString")));

        services.AddScoped(typeof(IGeneralRepository<>), typeof(GeneralRepository<>));
        services.AddScoped<IGeneralRepository<Booking>, GeneralRepository<Booking>>();
        services.AddScoped<IGeneralRepository<Infrastructure.Data.Models.MeetingRoom>, GeneralRepository<Infrastructure.Data.Models.MeetingRoom>>();
        services.AddScoped<IGeneralRepository<RefreshToken>, GeneralRepository<RefreshToken>>();
        services.AddScoped<IGeneralRepository<User>, GeneralRepository<User>>();

        return services;
    }
}
