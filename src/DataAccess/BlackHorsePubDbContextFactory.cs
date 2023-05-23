using DataAccess.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace DataAccess;

public class BlackHorsePubDbContextFactory : IDesignTimeDbContextFactory<BlackHorsePubDbContext>
{
    public BlackHorsePubDbContext CreateDbContext(string[] args)
    {
        var connectionString = Environment.GetEnvironmentVariable("MigrationConnectionString") ?? 
                               "Server=.;Database=TheBlackHorseDb;Trusted_Connection=True;MultipleActiveResultSets=True;TrustServerCertificate=True;";

        if (string.IsNullOrWhiteSpace(connectionString))
        {
            throw new MigrationConnectionStringNotProvidedException();
        }

        var optionBuilder = new DbContextOptionsBuilder<BlackHorsePubDbContext>();

        optionBuilder.UseSqlServer(connectionString, c =>
        {
            c.MigrationsAssembly(typeof(BlackHorsePubDbContextFactory).Assembly.FullName);
            c.EnableRetryOnFailure();
        });

        return new BlackHorsePubDbContext(optionBuilder.Options);
    }
}