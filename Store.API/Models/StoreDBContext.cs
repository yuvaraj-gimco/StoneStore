using Microsoft.EntityFrameworkCore;

namespace Store.API.Models
{
    public class StoreDBContext:DbContext
    {
        
        public StoreDBContext(DbContextOptions<StoreDBContext> options): base(options)
        {
            
        }

        public DbSet<Color> Colors { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Material> Materials { get; set; }
       
        public DbSet<Lot> Lots { get; set; }
        public DbSet<Slab> Slabs { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        public DbSet<Quotation> Quotations { get; set; }

        public DbSet<QuotationDetail> QuotationDetails { get; set; }

        
        public DbSet<Supplier> Supplier { get; set; }

        public DbSet<LotAudit> LotAudit { get; set; }


        public DbSet<Country> Countries { get; set; }

        public DbSet<LotStatus> LotStatus { get; set; }

        public DbSet<SlabStatus> SlabStatus { get; set; }

        public DbSet<SlabShape> SlabShape { get; set; }

        public DbSet<Finishing> Finishing { get; set; }

        public DbSet<Composition> Composition { get; set; }

        public DbSet<SlabThickness> SlabThickness { get; set; }

        public DbSet<MaterialQuality> MaterialQuality { get; set; }

        
    }
}