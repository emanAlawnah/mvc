using Microsoft.EntityFrameworkCore;
using session1.Models;

namespace session1.Data
{
    public class ApplicationDpContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=.; Database=mvc; Trusted_Connection=True; TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "cat1", Description = "this is cat 1" },
                 new Category { Id = 2, Name = "cat2", Description = "this is cat 2" },
               new Category { Id = 3, Name = "cat3", Description = "this is cat 3" }
                );
        }
    }
}
