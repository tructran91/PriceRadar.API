using Microsoft.EntityFrameworkCore;

namespace PriceRadar.Infrastructure.Data
{
    public class YourNewsDbContext : DbContext
    {
        public YourNewsDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
