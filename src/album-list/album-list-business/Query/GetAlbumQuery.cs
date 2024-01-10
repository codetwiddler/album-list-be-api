using album_list_business.DTO;
using album_list_business.Helper;
using MediatR;

namespace album_list_business.Query
{
    //get an Album by ID. Ties into MediatR's IRequest contract
    public class GetAlbumQuery : IRequest<Result<AlbumResponse>>
    {
        public int Id { get; set; }
        public GetAlbumQuery(int id)
        {
            Id = id;
        }
    }
}