using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Artists
{
    public class ArtistTrack : BaseEntity
    {
        public Guid ArtistId { get; set; }
        public Guid TrackId { get; set; }
    }
}
