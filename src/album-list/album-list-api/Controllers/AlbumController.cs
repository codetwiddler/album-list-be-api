using album_list_business.Command;
using album_list_business.DTO;
using album_list_business.Query;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace album_list_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AlbumController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly ILogger<AlbumController> _logger; //Logger implementation for future
        
        public AlbumController(IMediator mediator, ILogger<AlbumController> logger)
        {
            _mediator = mediator;
            _logger = logger;
        }

        [Produces("application/json")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<AlbumResponse>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(string))]
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var albumsQuery = new GetAlbumsQuery();
            var result = await _mediator.Send(albumsQuery);
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return NotFound();
        }

        [Produces("application/json")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(AlbumResponse))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(string))]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var albumQuery = new GetAlbumQuery(id);
            var result = await _mediator.Send(albumQuery);
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return NotFound();
        }

        [Produces("application/json")]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(AlbumResponse))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(string))]
        [HttpPost]
        public async Task<IActionResult> Post(CreateAlbumDto createAlbumDto)
        {
            var cmd = new CreateAlbumCommand(createAlbumDto);
            var result = await _mediator.Send(cmd);
            if (result.Success)
            {
                return StatusCode(201, result.Data);
            }

            return BadRequest(result.Data);
        }

        [Produces("application/json")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(AlbumResponse))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(string))]
        [HttpPatch("{id}")]
        public async Task<IActionResult> Update(int id, UpdateAlbumDto updateAlbumDto)
        {


            var cmd = new UpdateAlbumCommand(id, updateAlbumDto);
            var result = await _mediator.Send(cmd);

            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Data);
        }

        [Produces("application/json")]
        //[ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(bool))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(string))]
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var albumCommand = new DeleteAlbumCommand(id);
            var result = await _mediator.Send(albumCommand);
            if (result.Success)
            {
                return NoContent();
                
                //if we were interested in returning something to the client in the way
                //of details regarding that which was deleted, we might swap to using a
                //200 and include some relevant data. 204 is efficient since nothing returns.
                //return Ok($"Deleted Album Id: {id}");
            }

            return NotFound(result.Data);
        }
    }
}
