using BlogSphere.Models;
using Microsoft.EntityFrameworkCore;

namespace BlogSphere.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
            
        }

        public DbSet<Post> Posts { get; set; }
        public DbSet<Category> Categories{ get; set; }
        public DbSet<Comment> Comments { get; set; }

    }
}
