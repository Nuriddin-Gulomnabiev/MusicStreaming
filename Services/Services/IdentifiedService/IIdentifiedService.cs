using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services.IdentifiedService
{
    public interface IIdentifiedService
    {
        public void SetToken(string token);
        public void SetUserId(Guid userId);
        public string GetToken();
        public Guid GetUserId();
    }
}
