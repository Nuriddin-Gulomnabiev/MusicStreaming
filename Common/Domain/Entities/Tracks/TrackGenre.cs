using Domain.Common;
using Domain.Entities.Genres;

namespace Domain.Entities.Tracks
{
    public class TrackGenre : BaseEntity
    {
        public Guid TrackId { get; set; }
        public Track Track { get; set; }

        public Guid GenreId { get; set; }
        public Genre Genre { get; set; }
    }
}
