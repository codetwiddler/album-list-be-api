using album_list_model;

namespace album_list_ef
{
    public class AlbumRepository : IAlbumRepository
    {
        private readonly AlbumDbContext _dbContext;

        public AlbumRepository()
        {
            _dbContext = new AlbumDbContext();
        }

        public void AddAlbum(Album album)
        {
            _dbContext.Albums.Add(album);
            _dbContext.SaveChanges();
        }

        public Album GetAlbumById(int id)
        {
            return _dbContext.Albums.Find(id);
        }

        public IQueryable<Album> GetAllAlbums()
        {
            return _dbContext.Albums.AsQueryable();
        }

        public void UpdateAlbum(Album updatedAlbum)
        {
            var existingAlbum = _dbContext.Albums.Find(updatedAlbum.Id);

            if (existingAlbum != null)
            {
                existingAlbum.Title = updatedAlbum.Title;
                existingAlbum.Artist = updatedAlbum.Artist;
                existingAlbum.ReleaseYear = updatedAlbum.ReleaseYear;
                existingAlbum.Genre = updatedAlbum.Genre;

                _dbContext.SaveChanges();
            }
        }

        public void DeleteAlbum(int id)
        {
            var albumToDelete = _dbContext.Albums.Find(id);

            if (albumToDelete != null)
            {
                _dbContext.Albums.Remove(albumToDelete);
                _dbContext.SaveChanges();
            }
        }
    }

}
