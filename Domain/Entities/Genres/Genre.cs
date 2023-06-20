using Domain.Common;
using Domain.Entities.Tracks;

namespace Domain.Entities.Genres
{
    public class Genre : BaseEntity
    {
        public string Name { get; set; }
        public int Code { get; set; }
        public bool IsActive { get; set; }
        public virtual ICollection<TrackGenre> TrackGenres { get; set; }
    }
}
