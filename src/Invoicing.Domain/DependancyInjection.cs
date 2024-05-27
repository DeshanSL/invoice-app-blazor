using Microsoft.Extensions.DependencyInjection;

namespace Invoicing.Domain;

public static class DependancyInjection
{
    public static IServiceCollection AddDomain(this IServiceCollection services)
    {
        return services;

    }

}
