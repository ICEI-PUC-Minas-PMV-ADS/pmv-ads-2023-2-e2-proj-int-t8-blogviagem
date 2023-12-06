using Microsoft.EntityFrameworkCore;

namespace BlogViagem.Models
{
    public class AppDbContext : DbContext
    {
        private Post post;

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public AppDbContext(Post post)
        {
            this.post = post;
        }

        public DbSet<Post> Posts { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }
    }
}
