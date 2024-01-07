using album_list_business.DTO;
using album_list_business.Query;
using album_list_model;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace album_list_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AlbumController : ControllerBase
    {
        private readonly ILogger<AlbumController> _logger;
        private IMediator _mediator;
        protected IMediator Mediator => _mediator ??= HttpContext.RequestServices.GetService<IMediator>();

        public AlbumController(ILogger<AlbumController> logger)
        {
            _logger = logger;
        }

        [Produces("application/json")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(AlbumResponse))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(string))]
        [HttpGet("GetAllAlbums")]
        public async Task<IActionResult> Get()
        {
            

            return NotFound();
        }

        [Produces("application/json")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(AlbumResponse))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(string))]
        [HttpGet("GetAlbumById")]
        public async Task<IActionResult> GetById(int id)
        {
            var albumQuery = new GetAlbumQuery(id);
            var result = await Mediator.Send(albumQuery);
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return NotFound();
        }

        [HttpPost(Name = "SaveAlbum")]
        public IEnumerable<Album> Post(int Id)
        {

            return null;
        }
    }
}
