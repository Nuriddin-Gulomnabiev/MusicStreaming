using Domain.Common;
using Domain.Entities.Albums;

namespace Domain.Entities.Genres
{
    public class Genre : BaseEntity
    {
        public string Name { get; set; }
        public int Code { get; set; }
        public bool IsActive { get; set; }
        public virtual ICollection<AlbumGenre> AlbumGenres { get; set; }
    }
}
