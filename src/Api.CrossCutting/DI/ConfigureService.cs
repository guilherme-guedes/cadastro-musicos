using Domain.IService;
using Microsoft.Extensions.DependencyInjection;
using Service.Services;

namespace CrossCutting.DI
{
    public class ConfigureService
    {
        public static void ConfigureServiceDependencies(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IMusicianService, MusicianService>();
        }
    }
}