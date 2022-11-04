using MediatR;
using FileManager.Application.Common.Helpers;

namespace FileManager.Application.Features.Tracks.Commands.AddTrack
{
    internal class AddTrackHandler : IRequestHandler<AddTrackCommand>
    {
        private readonly string WebRootPath;

        public AddTrackHandler(DirectoryPathSettings wwwroot)
        {
            WebRootPath = wwwroot.WebRootPath;
        }

        public async Task<Unit> Handle(AddTrackCommand request, CancellationToken cancellationToken)
        {
            var fileName = request.TrackFile.FileName.Replace(".mp3", "");

            var path = Path.Combine(WebRootPath, "tracks", $"{fileName}.mp3");

            using (var fileStream = new FileStream(path, FileMode.Create))
            {
                await request.TrackFile.CopyToAsync(fileStream, CancellationToken.None);
            }

            return Unit.Value;
        }
    }
}
