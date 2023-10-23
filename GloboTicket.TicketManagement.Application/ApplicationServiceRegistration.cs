using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace GloboTicket.TicketManagement.Application;

public static class ApplicationServiceRegistration
{
    public static IServiceCollection AddApplicationCore(this IServiceCollection services)
    {
        services.AddMediatR(config =>
        {
            config.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
        });

        return services;
    }
}
