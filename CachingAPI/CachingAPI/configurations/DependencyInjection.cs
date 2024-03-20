using CachingAPI.Services.Caching;
using CachingAPI.Services;
using CachingAPI.Services.interfaces;

namespace CachingAPI.configurations
{
    public static class DependencyInjection
    {
        public static void AddInfrastructure(this IServiceCollection service)
        {
            service.AddScoped<CarStore>();
            service.AddScoped<ICarStore, CarCachingDecorator<CarStore>>();
        }
    }
}
