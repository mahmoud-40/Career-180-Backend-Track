using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EF_Day2.Models
{
    public class BlogContext : DbContext
    {
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Catalog> Catalogs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies().UseSqlServer(@"Server=MAHMOUD;Database=DayTwoEF;TrustServerCertificate=True;Trusted_Connection=True;");
        }
    }
}
