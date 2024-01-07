using album_list_business.DTO;
using album_list_business.Helper;
using MediatR;

namespace album_list_business.Command
{
    public class DeleteAlbumCommand: IRequest<Result<string>>
    {
        public int Id { get; set; }
        public DeleteAlbumCommand(int id)
        {
            Id = id;
        }
    }
}