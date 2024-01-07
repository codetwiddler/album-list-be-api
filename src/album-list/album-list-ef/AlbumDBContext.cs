using album_list_model;
using Microsoft.EntityFrameworkCore;

namespace album_list_ef
{
    public class AlbumDbContext : DbContext
    {
        public DbSet<Album> Albums { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("AlbumDatabase");
        }
    }
}