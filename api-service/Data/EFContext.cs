using api_service.Model;
using Microsoft.EntityFrameworkCore;

namespace api_service.Data
{
    public class EFContext : DbContext
    {
        public EFContext(DbContextOptions<EFContext> options) :base(options) 
        {            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasIndex(u => u.Username).IsUnique();
            modelBuilder.Entity<User>().HasIndex(u => u.Email).IsUnique();

            modelBuilder.Seed();

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<User> Users { get; set; }
    }
}
