namespace AdminPanel.Application.Features.Artists.Queries.GetArtist
{
    public class GetArtistViewModel
    {
        public string Name { get; set; }
        public int Code { get; set; }

        public Dictionary<int, string> Albums { get; set; }
    }
}
