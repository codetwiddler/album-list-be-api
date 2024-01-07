using album_list_business.Command;
using album_list_business.DTO;
using album_list_business.Helper;
using album_list_ef;
using album_list_model;
using MediatR;

namespace album_list_business.Handler
{
    public class CreateAlbumHandler : IRequestHandler<CreateAlbumCommand, Result<AlbumResponse>>
    {
        private readonly AlbumRepository _albumRepository;

        public CreateAlbumHandler(AlbumRepository albumRepository)
        {
            _albumRepository = albumRepository;
        }

        public async Task<Result<AlbumResponse>> Handle(CreateAlbumCommand request, CancellationToken cancellationToken)
        {

            var album = new Album
            {
                Title = request.Title,
                Artist = request.Artist,
                ReleaseYear = request.ReleaseYear,
                Genre = request.Genre,
            };

            _albumRepository.AddAlbum(album);            

            return new Result<AlbumResponse>(true, album.ToResponse());
        }
    }
}
