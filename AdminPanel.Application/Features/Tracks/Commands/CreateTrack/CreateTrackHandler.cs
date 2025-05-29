using AdminPanel.Application.Common.Handlers;
using AdminPanel.Application.Common.Interfaces;
using AutoMapper;
using Domain.Entities.Artists;
using Domain.Entities.Tracks;
using Domain.Exceptions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using NAudio.Wave;
using Services.Services.FileManager;

namespace AdminPanel.Application.Features.Tracks.Commands.CreateTrack
{
    internal class CreateTrackHandler : BaseCommandQueryHandler, IRequestHandler<CreateTrackCommand>
    {
        private readonly IFileManagerService fileManagerService;

        public CreateTrackHandler(IAdminApplicationDbContext dbContext, IMapper mapper, IFileManagerService fileManagerService) : base(dbContext, mapper)
        {
            this.fileManagerService = fileManagerService;
        }

        public async Task<Unit> Handle(CreateTrackCommand request, CancellationToken cancellationToken)
        {
            var album = await dbContext.Albums.Where(a => a.Code == request.AlbumCode).FirstOrDefaultAsync()
                ?? throw new ResourceNotFoundException("Альбом не найден");

            var artists = await GetArtists(request.ArtistsCodes);

            using var memoryStream = new MemoryStream();
            await request.Track.CopyToAsync(memoryStream, cancellationToken);
            memoryStream.Position = 0;

            using var mp3Reader = new Mp3FileReader(memoryStream);
            TimeSpan duration = mp3Reader.TotalTime;

            using var tran = dbContext.Database.BeginTransaction();
            try
            {
                var track = new Track()
                {
                    Id = Guid.NewGuid(),
                    Name = request.Name,
                    AlbumId = album.Id,
                    Duration = Convert.ToDecimal(duration.TotalSeconds),
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

                var trackGenres = GenreIdEnum.GenerateRandomGenres(track.Id);

                dbContext.Tracks.Add(track);
                dbContext.TrackGenres.AddRange(trackGenres);
                dbContext.ArtistTracks.AddRange(artistsTracks);

                await fileManagerService.CreateTrack(request.Track, track.Id);

                await dbContext.SaveChangesAsync();
                tran.Commit();

                return Unit.Value;
            }
            catch (Exception)
            {
                tran.Rollback();

                throw;
            }
        }

        private async Task<List<Artist>> GetArtists(List<int> artistsCode)
        {
            var artistsCodes = artistsCode.Distinct();
            var artists = new List<Artist>();

            foreach (var artistCode in artistsCodes)
            {
                var artist = await dbContext.Artists.Where(a => a.Code == artistCode).FirstOrDefaultAsync()
                    ?? throw new ResourceNotFoundException("Исполнитель не найден");

                artists.Add(artist);
            }

            return artists;
        }
    }

    public static class GenreIdEnum
    {
        public static Guid Trap = new Guid("ae14797c-31cd-432a-b2de-b3db95a82ab4");
        public static Guid HipHop = new Guid("8745e56f-b335-43fe-bd10-bad6bead0892");
        public static Guid Emo = new Guid("baa56e06-9672-4118-aee3-4098cec4581e");
        public static Guid CloudRap = new Guid("2f044c88-a983-4cf5-bcc1-a5d7764507ed");
        public static Guid AlternativeRock = new Guid("e2a8929f-2190-4329-bae1-83b170a3677f");
        public static Guid Pop = new Guid("ac38a647-9bc3-4a14-ae64-8c50964e307d");
        public static Guid RnB = new Guid("da7a689b-5b29-4c88-91ad-b543ce614e12");
        public static Guid RhythmAndBlues = new Guid("d35e2479-8214-41f2-b6d6-59b892602f16");
        public static Guid PopRock = new Guid("8ff3eaba-b2c6-4a1b-96c9-0f611d17e8c6");
        public static Guid Country = new Guid("a579446d-0ca1-4aae-8cad-5126ab41c203");
        public static Guid Folk = new Guid("f13c6c62-c6e2-4a37-9c17-99c0e9d8db42");
        public static Guid Metal = new Guid("b56de1bf-2c8e-4d1f-a727-9a5ebc3d6b2f");
        public static Guid Blues = new Guid("f1344d39-707e-4a7f-82e7-0816c21206d8");
        public static Guid Jazz = new Guid("7fa5ae48-7ed7-42a7-bb2a-4f4d0e502d7a");
        public static Guid Disco = new Guid("68f6170a-12b9-4f32-9e83-c81c61ad29b6");
        public static Guid Romance = new Guid("8c9c6d68-01f0-4e97-9640-d7a633788f53");

        private static readonly List<Guid> AllGenreIds = new List<Guid>
            {
                Trap,
                HipHop,
                Emo,
                CloudRap,
                AlternativeRock,
                Pop,
                RnB,
                RhythmAndBlues,
                PopRock,
                Country,
                Folk,
                Metal,
                Blues,
                Jazz,
                Disco,
                Romance
            };

        private static readonly Random _random = new Random();

        public static List<TrackGenre> GenerateRandomGenres(Guid trackId)
        {
            int count = _random.Next(1, 4);
            var selectedGenres = AllGenreIds.OrderBy(x => _random.Next()).Take(count).ToList();

            return selectedGenres.Select(genreId => new TrackGenre
            {
                Id = Guid.NewGuid(),
                TrackId = trackId,
                GenreId = genreId
            }).ToList();
        }
    }
}
