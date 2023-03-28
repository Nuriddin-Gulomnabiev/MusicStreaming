namespace Client.Application.Features.Playlists.Query.GetPlaylist
{
    public class GetPlaylistViewModel
    {
        public List<TrackViewModel> Tracks { get; set; }

        public class TrackViewModel
        {
            public string Name { get; set; }
            public int Code { get; set; }
        }
    }
}
