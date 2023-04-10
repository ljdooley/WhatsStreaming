using Microsoft.EntityFrameworkCore;
using WhatsStreaming.Data.Entities;

namespace WhatsStreaming.Data
{
    public class WhatsStreamingContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Show> Shows { get; set; }
        public DbSet<StreamingService> StreamingServices { get; set; }

        public WhatsStreamingContext(DbContextOptions<WhatsStreamingContext> options) : base(options) { }
    }
}
