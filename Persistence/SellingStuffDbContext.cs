using Microsoft.EntityFrameworkCore;
using SellingStuff.Models;

namespace SellingStuff.Persistence
{
    public class SellingStuffDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        
        public SellingStuffDbContext(DbContextOptions<SellingStuffDbContext> options)
            : base(options)
        {
            
        }
    }
}