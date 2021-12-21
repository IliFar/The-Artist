using Microsoft.EntityFrameworkCore;

namespace The_Artist.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            this.Database.EnsureCreated();
        }

        public DbSet<Art> Arts { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // seed Categories
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Chairs", Description = "All The Power Chairs" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "Hammers", Description = "All The Power Chairs" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "Knives", Description = "All The Power Chairs" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 4, CategoryName = "Lamps", Description = "All The Power Chairs" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 5, CategoryName = "Boats", Description = "All The Power Chairs" });


            // seed arts
            modelBuilder.Entity<Art>().HasData(new Art
            {
                Id = 1,
                Title = "Hammer Of Thor",
                Description = "Hammer Of Thor Is....",
                Image = "/images/hammer.jpg",
                Price = 18.25M,
                CategoryId = 2
            });
            
            modelBuilder.Entity<Art>().HasData(new Art
            {
                Id = 2,
                Title = "Lamp Of Loki",
                Description = "Lamp Of Loki is....",
                Image = "/images/lamp.jpg",
                Price = 49.25M,
                CategoryId = 4
            });
            
            modelBuilder.Entity<Art>().HasData(new Art
            {
                Id = 3,
                Title = "Chair Of Kings",
                Description = "Chair Of Kings is....",
                Image = "/images/chair.jpg",
                Price = 100.25M,
                CategoryId = 1
            });
            
            modelBuilder.Entity<Art>().HasData(new Art
            {
                Id = 4,
                Title = "Knife Of Valhala",
                Description = "Knife Of Valhala is....",
                Image = "/images/knife.jpg",
                Price = 298.25M,
                CategoryId = 3
            });
            
            modelBuilder.Entity<Art>().HasData(new Art
            {
                Id = 5,
                Title = "Boat Of Poseidon",
                Description = "Boat Of Poseidon is....",
                Image = "/images/boat.jpg",
                Price = 55.25M,
                CategoryId = 5
            });
        }
    }
}
