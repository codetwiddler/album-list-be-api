using album_list_business.DTO;
using album_list_business.Helper;
using MediatR;

namespace album_list_business.Query
{
    public class GetAlbumsQuery : IRequest<Result<List<AlbumResponse>>>
    {
        public GetAlbumsQuery()
        {
        }
    }
}