using MapsAndWeatherData.Extensions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MapsAndWeatherService.Extensions
{
    public static class Extensions
    {
        public static IServiceCollection ConfigureMapsAndWeatherServices(this IServiceCollection services, IConfiguration configuration)
        {
            // Add service configurations here in the future
            services.AddDataAccess(configuration);
            return services;
        }
    }
}
