using album_list_business.DTO;
using album_list_business.Helper;
using MediatR;

namespace album_list_business.Command
{
    public class UpdateAlbumCommand : IRequest<Result<AlbumResponse>>
    {
        public int    Id { get; set; }
        public string Title { get; set; }
        public string Artist { get; set; }
        public int    ReleaseYear { get; set; }
        public string Genre { get; set; }
        public int    Rating { get; set; }

        public UpdateAlbumCommand(int id, UpdateAlbumDto updateAlbumDto)
        {
            Id          = id;
            Title       = updateAlbumDto.Title;
            Artist      = updateAlbumDto.Artist;
            ReleaseYear = updateAlbumDto.ReleaseYear;
            Genre       = updateAlbumDto.Genre;
            Rating      = updateAlbumDto.Rating;
        }
    }
}
