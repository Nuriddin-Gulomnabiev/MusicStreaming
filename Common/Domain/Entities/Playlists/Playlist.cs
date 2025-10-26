using Domain.Common;
using Domain.Entities.Artists;

namespace Domain.Entities.Playlists
{
    public class Playlist : BaseEntity
    {
        public string Title { get; set; }
        public int Code { get; set; }
        public Guid CreatedByArtistId { get; set; }
        public bool IsPublic { get; set; }
        public bool IsActive { get; set; }
        public string CoverUrl { get; set; }
        public DateTime LastUpdatedAt { get; set; }

        public Artist CreatedByArtist { get; set; }
        public virtual ICollection<PlaylistTrack> PlaylistTracks { get; set; }
    }
}
