using DataAccess.Domain;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class BlackHorsePubDbContext: DbContext
    {
        public BlackHorsePubDbContext(DbContextOptions<BlackHorsePubDbContext> optionBuilder) : base(optionBuilder) { }

        public DbSet<Customer> Customers => Set<Customer>();
        public DbSet<Address> Addresses => Set<Address>();
        public DbSet<Order> Orders => Set<Order>();
        
        // public DbSet<Employee> Employees => Set<Employee>();
        // 
        // public DbSet<OrderDetail> OrderDetails => Set<OrderDetail>();
        // public DbSet<Product> Products => Set<Product>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(BlackHorsePubDbContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
