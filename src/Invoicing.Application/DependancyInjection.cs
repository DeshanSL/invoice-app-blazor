using Microsoft.Extensions.DependencyInjection;

namespace Invoicing.Application;

public static class DependancyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        return services;
    }

}
