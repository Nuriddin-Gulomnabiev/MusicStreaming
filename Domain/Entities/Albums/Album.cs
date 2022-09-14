using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Albums
{
    public class Album : BaseEntity
    {
        public string Name { get; set; }
        public int Code { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}
