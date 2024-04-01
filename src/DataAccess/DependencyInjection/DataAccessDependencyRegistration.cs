using DataAccess.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace DataAccess.DependencyInjection;

public static class DataAccessDependencyRegistration
{
    public static void AddDataAccess(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddTransient<IProductRepository, ProductRepository>();
    }
}