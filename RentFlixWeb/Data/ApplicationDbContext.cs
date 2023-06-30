using Microsoft.EntityFrameworkCore;
using RentFlixWeb.Models;
using DbContext = Microsoft.EntityFrameworkCore.DbContext;

namespace RentFlixWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Action", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Documentary", DisplayOrder = 2 },
                new Category { Id = 3, Name = "Drama", DisplayOrder = 3 },
                new Category { Id = 4, Name = "RomCom", DisplayOrder = 4 }
                );
        }
    }
}
