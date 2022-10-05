using Domain.Common;
using Domain.Entities.Artists;
using Domain.Entities.Genres;
using Domain.Entities.Tracks;

namespace Domain.Entities.Albums
{
    public class Album : BaseEntity
    {
        public string Name { get; set; }
        public int Code { get; set; }
        public DateTime ReleaseDate { get; set; }
        public virtual ICollection<Genre> Genres { get; set; }
        public virtual ICollection<ArtistAlbum> ArtistAlbums { get; set; }
        public virtual ICollection<AlbumGenre> AlbumGenres { get; set; }
        public virtual ICollection<Track> Tracks { get; set; }
    }
}
