using album_list_business.DTO;
using album_list_business.Helper;
using album_list_business.Query;
using album_list_ef;
using MediatR;

namespace album_list_business.Handler
{
    public class GetAlbumHandler : IRequestHandler<GetAlbumQuery, Result<AlbumResponse>>
    {
        private readonly IAlbumRepository _albumRepository;

        public GetAlbumHandler(IAlbumRepository albumRepository)
        {
            _albumRepository = albumRepository;
        }

        public async Task<Result<AlbumResponse>> Handle(GetAlbumQuery request, CancellationToken cancellationToken)
        {
            var result = _albumRepository.GetAlbumById(request.Id);
            if (result == null)
            {
                return new Result<AlbumResponse>(false, null);
            }
            return new Result<AlbumResponse>(true, result.ToResponse());
        }
    }   
}
