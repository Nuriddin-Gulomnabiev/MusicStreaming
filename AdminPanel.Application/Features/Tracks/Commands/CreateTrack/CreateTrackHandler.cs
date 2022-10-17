using AdminPanel.Application.Common.Exceptions;
using AdminPanel.Application.Common.Handlers;
using AdminPanel.Application.Common.Interfaces;
using AutoMapper;
using Domain.Entities.Artists;
using Domain.Entities.Tracks;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace AdminPanel.Application.Features.Tracks.Commands.CreateTrack
{
    internal class CreateTrackHandler : BaseCommandQueryHandler, IRequestHandler<CreateTrackCommand, Guid>
    {
        public CreateTrackHandler(IAdminApplicationDbContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
        }

        public async Task<Guid> Handle(CreateTrackCommand request, CancellationToken cancellationToken)
        {
            using(var tran = dbContext.Database.BeginTransaction())
            {
                try
                {
                    var album = await dbContext.Albums.Where(a => a.Code == request.AlbumCode).FirstOrDefaultAsync()
                        ?? throw new ResourceNotFound("Альбом не найден");

                    var artistsCodes = request.ArtistsCodes.Distinct();
                    var artists = new List<Artist>();

                    foreach (var artistCode in artistsCodes)
                    {
                        var artist = await dbContext.Artists.Where(a => a.Code == artistCode).FirstOrDefaultAsync()
                            ?? throw new ResourceNotFound("Исполнитель не найден");

                        artists.Add(artist);
                    }

                    var track = new Track()
                    {
                        Id = Guid.NewGuid(),
                        Name = request.Name,
                        AlbumId = album.Id,
                        IsActive = true
                    };

                    var artistsTracks = artists.Select(a => 
                        new ArtistTrack 
                        { 
                            Id = Guid.NewGuid(), 
                            TrackId = track.Id,
                            ArtistId = a.Id
                        }
                    );

                    dbContext.Tracks.Add(track);
                    dbContext.ArtistTracks.AddRange(artistsTracks);

                    await dbContext.SaveChangesAsync();
                    tran.Commit();

                    return track.Id;
                }
                catch (Exception)
                {
                    tran.Rollback();

                    throw;
                }
            }
        }
    }
}
