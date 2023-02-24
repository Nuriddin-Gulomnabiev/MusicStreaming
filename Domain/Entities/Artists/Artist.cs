using Domain.Common;
using Domain.Entities.Sessions;

namespace Domain.Entities.Artists
{
    public class Artist : BaseEntity
    {
        public string Name { get; set; }
        public int Code { get; set; }
        public bool IsActive { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public virtual ICollection<ArtistAlbum> ArtistAlbums { get; set; }
        public virtual ICollection<ArtistTrack> ArtistTracks { get; set; }
        public virtual ICollection<Session> Sessions { get; set; }
    }
}
