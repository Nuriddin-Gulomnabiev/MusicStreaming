using FileManager.Application.Common.Helpers;
using FileManager.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FileManager.Application.Features.Tracks.Queries.GetTrack
{
    internal class GetTrackHandler : IRequestHandler<GetTrackQuery, Stream>
    {
        private readonly string WebRootPath;
        private readonly IFileManagerDbContext dbContext;

        public GetTrackHandler(IFileManagerDbContext dbContext, DirectoryPathSettings wwwroot)
        {
            this.dbContext = dbContext;
            WebRootPath = wwwroot.WebRootPath;
        }

        public async Task<Stream> Handle(GetTrackQuery request, CancellationToken cancellationToken)
        {
            var track = await dbContext.Tracks.Where(t => t.Code == request.Code && t.IsActive).FirstOrDefaultAsync(cancellationToken)
                ?? throw new FileNotFoundException();

            var path = Path.Combine(WebRootPath, "tracks", $"{track.Id}.mp3");

            return File.OpenRead(path);
        }
    }
}
