using Microsoft.AspNetCore.Http;
using MediatR;

namespace AdminPanel.Application.Features.Tracks.Commands.CreateTrack
{
    public class CreateTrackCommand : IRequest<Guid>
    {
        public string Name { get; set; }
        public int AlbumCode { get; set; }
        public List<int> ArtistsCodes { get; set; }
        public IFormFile Track { get; set; }
    }
}
