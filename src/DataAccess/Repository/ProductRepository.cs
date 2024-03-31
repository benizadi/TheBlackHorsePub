using DataAccess.Domain;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repository;

public class ProductRepository : IProductRepository
{
    public ProductRepository(BlackHorsePubDbContext dbContext)
    {
        DbContext = dbContext;
    }

    private BlackHorsePubDbContext DbContext { get; set; }

    public async Task<Product?> GetProductById(Guid productId)
    {
        return await DbContext.Products.FirstOrDefaultAsync(product => product.ProductId == productId);
    }
}

public interface IProductRepository //todo: add to DI
{
    Task<Product?> GetProductById(Guid productId);
}