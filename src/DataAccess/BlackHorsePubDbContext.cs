using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging.Abstractions;

namespace DataAccess
{
    public class BlackHorsePubDbContext: DbContext
    {
        public BlackHorsePubDbContext(DbContextOptions<BlackHorsePubDbContext> optionBuilder) : base(optionBuilder)
        {
            
        }
    }
}
