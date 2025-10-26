using MediatR;
using Microsoft.AspNetCore.Http;

namespace FileManager.Application.Features.Tracks.Commands.AddTrack
{
    public class AddTrackCommand : IRequest
    {
        public IFormFile TrackFile { get; set; }

        public AddTrackCommand(IFormFile file)
        {
            TrackFile = file;
        }
    }
}
