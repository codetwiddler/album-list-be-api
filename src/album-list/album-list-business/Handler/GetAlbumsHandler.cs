using album_list_business.DTO;
using album_list_business.Helper;
using album_list_business.Query;
using album_list_ef;
using MediatR;

namespace album_list_business.Handler
{
    public class GetAlbumsHandler : IRequestHandler<GetAlbumsQuery, Result<List<AlbumResponse>>>
    {
        private readonly IAlbumRepository _albumRepository;

        public GetAlbumsHandler(IAlbumRepository albumRepository)
        {
            _albumRepository = albumRepository;
        }

        public async Task<Result<List<AlbumResponse>>> Handle(GetAlbumsQuery request, CancellationToken cancellationToken)
        {
            var entities = _albumRepository.GetAllAlbums();
            var responses = entities.Select(x => x.ToResponse());
            return new Result<List<AlbumResponse>>(true, responses.ToList());
        }
    }   
}