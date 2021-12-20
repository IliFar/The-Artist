using Microsoft.EntityFrameworkCore;

namespace The_Artist.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Art> Arts { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
