using album_list_model;
using Microsoft.EntityFrameworkCore;

namespace album_list_ef
{
    public class AlbumDbContext : DbContext
    {
        public DbSet<Album> Albums { get; set; }

        public AlbumDbContext(DbContextOptions<AlbumDbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseInMemoryDatabase("AlbumDatabase");
            }
        }
    }
}