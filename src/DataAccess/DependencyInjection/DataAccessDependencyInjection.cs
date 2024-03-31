using DataAccess.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace DataAccess.DependencyInjection;

public class DataAccessDependencyInjection
{
    public void AddService(IServiceCollection serviceCollection)
    {
        serviceCollection.AddTransient<IProductRepository, ProductRepository>();
    }
}