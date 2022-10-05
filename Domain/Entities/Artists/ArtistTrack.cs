using Domain.Common;
using Domain.Entities.Tracks;

namespace Domain.Entities.Artists
{
    public class ArtistTrack : BaseEntity
    {
        public Guid ArtistId { get; set; }
        public Artist Artist { get; set; }

        public Guid TrackId { get; set; }
        public Track Track { get; set; }
    }
}
