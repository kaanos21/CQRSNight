using CQRSNight.Dal.Entities;
using Microsoft.EntityFrameworkCore;

namespace CQRSNight.Dal.Context
{
    public class CQRSContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-COQ9ECD\\SQLEXPRESS;database=CQRSDb3;integrated security=true");
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Schdule> Schdules { get; set; }
    }
}
