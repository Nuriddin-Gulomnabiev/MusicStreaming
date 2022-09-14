using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Artists
{
    public class Artist : BaseEntity
    {
        public string Name { get; set; }
        public int Code { get; set; }
    }
}
