using Domain.Common;
using Domain.Entities.Albums;

namespace Domain.Entities.Artists
{
    public class ArtistAlbum : BaseEntity
    {
        public Guid ArtistId { get; set; }
        public Artist Artist { get; set; }

        public Guid AlbumId { get; set; }
        public Album Album { get; set; }
    }
}
