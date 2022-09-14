using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Albums
{
    public class AlbumGenre : BaseEntity
    {
        public Guid AlbumId { get; set; }
        public Guid GenreId { get; set; }
    }
}
