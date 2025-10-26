using Newtonsoft.Json;

namespace Client.Application.Features.Playlists.Query.GetPlaylist
{
    public class GetPlaylistViewModel
    {
        public string Title { get; set; }
        public int Code { get; set; }
        public bool IsPublic { get; set; }
        public string CoverUrl { get; set; }
        public DateTime LastUpdatedAt { get; set; }

        public List<TrackViewModel> Tracks { get; set; }

        public class TrackViewModel
        {
            public int Position { get; set; }
            public int Code { get; set; }
            public string Name { get; set; }

            public List<ArtistViewModel> Artists { get; set; }

            private string _ArtistJson;

            internal string ArtistsJson
            {
                get
                {
                    return _ArtistJson;
                }
                set
                {
                    _ArtistJson = value;
                    Artists = JsonConvert.DeserializeObject<List<ArtistViewModel>>(value);
                }
            }
        }

        public class ArtistViewModel
        {
            public int Code { get; set; }
            public string Name { get; set; }
        }
    }
}
