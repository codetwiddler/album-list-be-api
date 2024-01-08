using album_list_business.DTO;
using album_list_model;

namespace album_list_business.Helper
{
    public static class AlbumMapper
    {
        public static AlbumResponse ToResponse(this Album album)
        {
            var result = new AlbumResponse
            {
                Id = album.Id,
                Title = album.Title,
                Artist = album.Artist,
                ReleaseYear = album.ReleaseYear,
                Genre = album.Genre,
                Rating = album.Rating,
            };

            return result;
        }
    }
}
