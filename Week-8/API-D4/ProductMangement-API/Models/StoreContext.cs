using Microsoft.EntityFrameworkCore;

namespace ProductMangement_API.Models
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options) : base(options)
        {
        }

        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Catalog> Catalogs { get; set; }
    }
}
