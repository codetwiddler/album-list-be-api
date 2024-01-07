using album_list_model;
using Microsoft.AspNetCore.Mvc;

namespace album_list_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AlbumController : ControllerBase
    {
        private readonly ILogger<AlbumController> _logger;

        public AlbumController(ILogger<AlbumController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetAlbums")]
        public IEnumerable<Album> Get()
        {

            return null;
        }
    }
}
