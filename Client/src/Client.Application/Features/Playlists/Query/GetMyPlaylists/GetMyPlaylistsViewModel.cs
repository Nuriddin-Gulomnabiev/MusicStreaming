namespace Client.Application.Features.Playlists.Query.GetMyPlaylists
{
    public class GetMyPlaylistsViewModel
    {
        public string Title { get; set; }
        public int Code { get; set; }
        public string CoverUrl { get; set; }
        public bool IsPublic { get; set; }
    }
}
