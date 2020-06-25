using Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace CrossCutting.DI
{
    public class ConfigureContext
    {
        public static void ConfigureContextDependencies(IServiceCollection serviceCollection)
        {
            serviceCollection.AddDbContext<DataContext>(opt => opt.UseInMemoryDatabase("DB"));
        }
    }
}