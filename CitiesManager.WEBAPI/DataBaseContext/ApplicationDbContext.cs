using CitiesManager.WEBAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CitiesManager.WEBAPI.DataBaseContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base() 
        {
        }

        public ApplicationDbContext()
        {
        }
        public virtual DbSet<City> Cities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
