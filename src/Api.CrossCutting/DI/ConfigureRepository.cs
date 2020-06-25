using Data.Repositories;
using Domain.Entities;
using Domain.IRepositories;
using Microsoft.Extensions.DependencyInjection;

namespace CrossCutting.DI
{
    public class ConfigureRepository
    {
        public static void ConfigureRepositoryDependencies(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IRepository<Musician>, MusicianRepository>();
        }
    }
}