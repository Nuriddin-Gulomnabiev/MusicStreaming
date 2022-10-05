using AdminPanel.Application.Common.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AdminPanel.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<object> Get([FromServices] IAdminApplicationDbContext dbContext)
        {
            var albums = dbContext.Albums.Include(a => a.Tracks).ToList();

            var albumResponse = new List<AlbumReponse>();

            foreach (var album in albums)
            {
                var genres = dbContext.AlbumGenres.Where(ag => ag.AlbumId == album.Id).Select(ag => ag.Genre.Name).ToList();
                var artists = dbContext.ArtistAlbums.Where(ag => ag.AlbumId == album.Id).Select(ag => ag.Artist.Name).ToList();

                albumResponse.Add(new AlbumReponse
                {
                    AlbumName = album.Name,
                    Artists = string.Join(", ", artists),
                    Genres = string.Join(", ", genres),
                    Tracks = album.Tracks.Select(a => a.Name)
                });
            }

            return albumResponse;
        }

        public class AlbumReponse
        {
            public string AlbumName { get; set; }
            public string Artists { get; set; }
            public string Genres { get; set; }
            public IEnumerable<string> Tracks { get; set; }
        }
    }
}