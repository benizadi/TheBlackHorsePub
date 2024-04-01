using DataAccess.DependencyInjection;
using Microsoft.Extensions.Hosting;

var host = new HostBuilder()
    .ConfigureFunctionsWorkerDefaults()
    .ConfigureServices((services) =>
    {
        services.AddDataAccess();
    })
    .Build();


host.Run();