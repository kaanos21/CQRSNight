using CQRSNight.Dal.Entities;
using Microsoft.EntityFrameworkCore;

namespace CQRSNight.Dal.Context
{
    public class CQRSContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-COQ9ECD\\SQLEXPRESS;database=CQRSDb;integrated security=true");
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
