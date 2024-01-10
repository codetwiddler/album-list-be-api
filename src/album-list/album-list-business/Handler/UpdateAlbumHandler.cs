using album_list_business.Command;
using album_list_business.DTO;
using album_list_business.Helper;
using album_list_ef;
using album_list_model;
using MediatR;

namespace album_list_business.Handler
{
    public class UpdateAlbumHandler : IRequestHandler<UpdateAlbumCommand, Result<AlbumResponse>>
    {
        private readonly IAlbumRepository _albumRepository;

        public UpdateAlbumHandler(IAlbumRepository albumRepository)
        {
            _albumRepository = albumRepository;
        }

        public async Task<Result<AlbumResponse>> Handle(UpdateAlbumCommand request, CancellationToken cancellationToken)
        {

            var album = new Album
            {
                Id          = request.Id,
                Title       = request.Title,
                Artist      = request.Artist,
                ReleaseYear = request.ReleaseYear,
                Genre       = request.Genre,
                Rating      = request.Rating
            };

            _albumRepository.UpdateAlbum(album);            

            return new Result<AlbumResponse>(true, album.ToResponse());
        }
    }
}
