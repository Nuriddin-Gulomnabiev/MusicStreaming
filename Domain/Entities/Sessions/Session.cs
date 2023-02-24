using Domain.Common;
using Domain.Entities.Artists;

namespace Domain.Entities.Sessions
{
    public class Session : BaseEntity
    {
        public Guid ArtistId { get; set; }
        public string DeviceId { get; set; }
        public string RefreshToken { get; set; }
        public DateTime ExpiresAt { get; set; }

        public Artist Artist { get; set; }
    }
}
