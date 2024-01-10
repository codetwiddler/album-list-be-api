using album_list_business.DTO;
using album_list_business.Helper;
using MediatR;

namespace album_list_business.Command
{
    public class CreateAlbumCommand : IRequest<Result<AlbumResponse>>
    {
        public string Title { get; }
        public string Artist { get; }
        public int    ReleaseYear { get; }
        public string Genre { get; }
        public int    Rating { get; }

        public CreateAlbumCommand(CreateAlbumDto createAlbumDto)
        {
            Title       = createAlbumDto.Title;
            Artist      = createAlbumDto.Artist;
            ReleaseYear = createAlbumDto.ReleaseYear;
            Genre       = createAlbumDto.Genre;
            Rating      = createAlbumDto.Rating;
        }
    }
}
