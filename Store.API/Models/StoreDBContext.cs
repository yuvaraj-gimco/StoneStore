using Microsoft.EntityFrameworkCore;

namespace Store.API.Models
{
    public class StoreDBContext:DbContext
    {
        
        public StoreDBContext(DbContextOptions<StoreDBContext> options): base(options)
        {
            
        }

        public DbSet<Color> Colors { get; set; }
    }
}