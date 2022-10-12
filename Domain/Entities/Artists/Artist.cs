using Domain.Common;

namespace Domain.Entities.Artists
{
    public class Artist : BaseEntity
    {
        public string Name { get; set; }
        public int Code { get; set; }
        public bool IsActive { get; set; }
        public virtual ICollection<ArtistAlbum> ArtistAlbums { get; set; }
        public virtual ICollection<ArtistTrack> ArtistTracks { get; set; }
    }
}
