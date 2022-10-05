using Domain.Common;
using Domain.Entities.Albums;
using Domain.Entities.Artists;

namespace Domain.Entities.Tracks
{
    public class Track : BaseEntity
    {
        public string Name { get; set; }
        public int Code { get; set; }
        public Guid AlbumId { get; set; }

        public Album Album { get; set; }
        public virtual ICollection<ArtistTrack> ArtistTracks { get; set; }
    }
}
