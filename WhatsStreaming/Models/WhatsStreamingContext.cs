using Microsoft.EntityFrameworkCore;

namespace WhatsStreaming.Models
{
    public class WhatsStreamingContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Show> Shows { get; set; }
        public DbSet<StreamingService> StreamingServices { get; set; }

        public WhatsStreamingContext(DbContextOptions<WhatsStreamingContext> options) : base(options) { }
    }
}
