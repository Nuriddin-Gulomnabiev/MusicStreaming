using Domain.Common;
using Domain.Entities.Genres;

namespace Domain.Entities.Albums
{
    public class AlbumGenre : BaseEntity
    {
        public Guid AlbumId { get; set; }
        public Album Album { get; set; }

        public Guid GenreId { get; set; }
        public Genre Genre { get; set; }
    }
}
