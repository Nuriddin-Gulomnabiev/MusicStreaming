using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Artists
{
    public class ArtistAlbum
    {
        public Guid ArtistId { get; set; }
        public Guid AlbumId { get; set; }
    }
}
