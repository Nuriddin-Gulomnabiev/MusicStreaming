using AdminPanel.Application.Features.Albums.Commands.CreateAlbum;
using AdminPanel.Application.Features.Albums.Commands.EditAlbum;
using AdminPanel.Application.Features.Albums.Queries.GetAlbum;
using AdminPanel.Application.Features.Albums.Queries.GetAllAlbums;
using AdminPanel.Application.Features.Artists.Commands.CreateArtist;
using AdminPanel.Application.Features.Tracks.Commands.CreateTrack;
using AdminPanel.Web.Common.ModelRequests;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AdminPanel.Web.Controllers
{
    [Route("api/v{version:apiVersion}/albums")]
    public class AlbumsController : BaseController
    {
        public AlbumsController(IMediator mediator) : base(mediator)
        {
        }

        [HttpGet]
        public async Task<IActionResult> GetAlbums([FromQuery] GetAllAlbumsQuery query)
        {
            return Success(await mediator.Send(query));
        }

        [HttpGet("{code}")]
        public async Task<IActionResult> GetAlbum([FromRoute] int code)
        {
            return Success(await mediator.Send(new GetAlbumQuery(code)));
        }

        [HttpPost("create")]
        public async Task<IActionResult> CreateAlbum([FromBody] CreateAlbumCommand command)
        {
            return Success(await mediator.Send(command));
        }

        [HttpPost("create/full")]
        [AllowAnonymous]
        public async Task<IActionResult> CreateAlbumFull([FromForm] CreateAlbumFullModelRequest request)
        {
            var artistCode = await mediator.Send(new CreateArtistCommand
            {
                Name = request.ArtistName,
                IsActive = true
            });

            var albumCode = await mediator.Send(new CreateAlbumCommand
            {
                Name = request.AlbumName,
                ReleaseDate = request.ReleaseDate,
                ArtistsCodes = new List<int> { artistCode }
            });

            foreach (var track in request.Tracks)
            {
                await mediator.Send(new CreateTrackCommand
                {
                    Name = track.Name,
                    Track = track.Track,
                    AlbumCode = albumCode,
                    ArtistsCodes = new List<int> { artistCode }
                });
            }

            return Success(true);
        }

        [HttpPost("{code}/edit")]
        public async Task<IActionResult> EditAlbum([FromBody] EditAlbumCommand command, [FromRoute] int code)
        {
            command.Code = code;

            return Success(await mediator.Send(command));
        }
    }
}
