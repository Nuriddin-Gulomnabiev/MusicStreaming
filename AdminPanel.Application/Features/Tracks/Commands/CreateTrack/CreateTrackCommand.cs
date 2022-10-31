using MediatR;
using Microsoft.AspNetCore.Http;

namespace AdminPanel.Application.Features.Tracks.Commands.CreateTrack
{
    public class CreateTrackCommand : IRequest
    {
        public string Name { get; set; }
        public int AlbumCode { get; set; }
        public List<int> ArtistsCodes { get; set; }
        public IFormFile Track { get; set; }
    }
}
