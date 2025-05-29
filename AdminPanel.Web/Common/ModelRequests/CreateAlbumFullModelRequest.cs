namespace AdminPanel.Web.Common.ModelRequests
{
    public class CreateAlbumFullModelRequest
    {
        public string ArtistName { get; set; }
        public string AlbumName { get; set; }
        public DateTime ReleaseDate { get; set; }
        public List<TrackModelRequest> Tracks { get; set; }

        public class TrackModelRequest
        {
            public string Name { get; set; }
            public IFormFile Track { get; set; }
        }
    }
}
