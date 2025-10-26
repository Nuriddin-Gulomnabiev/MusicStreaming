using Domain.Common;
using Domain.Entities.Tracks;

namespace Domain.Entities.Playlists
{
    public class PlaylistTrack : BaseEntity
    {
        public Guid PlaylistId { get; set; }
        public Guid TrackId { get; set; }
        public decimal Position { get; set; }

        public Playlist Playlist { get; set; }
        public Track Track { get; set; }
    }
}
