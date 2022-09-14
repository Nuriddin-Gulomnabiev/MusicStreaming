using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Tracks
{
    public class Track : BaseEntity
    {
        public string Name { get; set; }
        public int Code { get; set; }
        public Guid AlbumId { get; set; }
    }
}
