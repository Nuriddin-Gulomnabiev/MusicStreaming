using MediatR;
using Microsoft.AspNetCore.Http;

namespace AdminPanel.Application.Features.Tracks.Commands.EditTrack
{
    public class EditTrackCommand : IRequest<bool>
    {
        public Guid Id { get; set; }
        public int Code { get; set; }
        public string Name { get; set; }
        public int AlbumCode { get; set; }
        public bool IsActive { get; set; }
        public IFormFile Track { get; set; }
        public bool IsTrackReloaded { get; set; }
        public IEnumerable<int> ArtistsCodes { get; set; }
    }
}
