using album_list_model;

namespace album_list_ef
{
    public interface IAlbumRepository
    {
        void AddAlbum(Album album);
        void DeleteAlbum(int id);
        Album GetAlbumById(int id);
        IQueryable<Album> GetAllAlbums();
        void UpdateAlbum(Album updatedAlbum);
    }
}