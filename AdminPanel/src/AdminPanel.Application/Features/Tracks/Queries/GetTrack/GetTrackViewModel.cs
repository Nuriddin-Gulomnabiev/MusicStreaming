namespace AdminPanel.Application.Features.Tracks.Queries.GetTrack
{
    public class GetTrackViewModel
    {
        public Guid Id { get; set; }
        public int Code { get; set; }
        public string Name { get; set; }
        public int AlbumCode { get; set; }
        public bool IsActive { get; set; }
        public decimal Duration { get; set; }

        public Dictionary<int, string> Artists { get; set; }
    }
}
