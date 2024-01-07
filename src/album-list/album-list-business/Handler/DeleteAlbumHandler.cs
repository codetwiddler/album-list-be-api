using album_list_business.Command;
using album_list_business.DTO;
using album_list_business.Helper;
using album_list_business.Query;
using album_list_ef;
using MediatR;

namespace album_list_business.Handler
{
    public class DeleteAlbumHandler : IRequestHandler<DeleteAlbumCommand, Result<string>>
    {
        private readonly IAlbumRepository _albumRepository;

        public DeleteAlbumHandler(IAlbumRepository albumRepository)
        {
            _albumRepository = albumRepository;
        }

        public async Task<Result<string>> Handle(DeleteAlbumCommand request, CancellationToken cancellationToken)
        {
            _albumRepository.DeleteAlbum(request.Id);
            return new Result<string>(true, string.Empty);
        }
    }   
}