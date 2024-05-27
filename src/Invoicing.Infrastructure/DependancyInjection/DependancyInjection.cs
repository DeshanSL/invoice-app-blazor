using Microsoft.Extensions.DependencyInjection;

namespace Invoicing.Infrastructure;

public static class DependancyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        return services;
    }
}
