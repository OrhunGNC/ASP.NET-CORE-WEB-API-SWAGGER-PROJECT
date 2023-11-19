using Microsoft.EntityFrameworkCore;

namespace coreapiswagger.Models
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Games> Gamess { get; set; }
        public DbSet<Developers> Developerss { get; set; }
        public DbSet<Publishers> Publisherss { get; set; }
        public DbSet<Platforms> Platformss { get; set; }

    }
}
