using Domain.Common;
using Domain.Entities.Albums;
using Domain.Entities.Artists;
using Domain.Entities.Playlists;

namespace Domain.Entities.Tracks
{
    public class Track : BaseEntity
    {
        public string Name { get; set; }
        public int Code { get; set; }
        public Guid AlbumId { get; set; }
        public bool IsActive { get; set; }
        public int Number { get; set; }
        public decimal Duration { get; set; }

        public Album Album { get; set; }
        public virtual ICollection<TrackGenre> TrackGenres { get; set; }
        public virtual ICollection<ArtistTrack> ArtistTracks { get; set; }
        public virtual ICollection<PlaylistTrack> PlaylistTracks { get; set; }
    }
}
