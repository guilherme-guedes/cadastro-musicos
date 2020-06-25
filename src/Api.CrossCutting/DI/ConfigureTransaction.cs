
using Data.Transaction;
using Microsoft.Extensions.DependencyInjection;

namespace CrossCutting.DI
{
    public class ConfigureTransaction
    {
        public static void ConfigureTransactionDependencies(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IUnitOfWork, UnitOfWork>();
        }
    }
}