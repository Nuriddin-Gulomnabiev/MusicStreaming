using FileManager.WebApi.Modules.Tracks.ModelRequests;
using Microsoft.AspNetCore.Mvc;

namespace FileManager.WebApi.Modules.Tracks
{
    [Route("api/v1/track")]
    public class TracksController : Controller
    {
        private readonly IWebHostEnvironment environment;

        public TracksController(IWebHostEnvironment environment)
        {
            this.environment = environment;
        }

        [HttpGet("{code}")]
        public FileStreamResult GetTrack([FromRoute] Guid code)
        {
            var currDirect = environment.WebRootPath;
            var path = Path.Combine(currDirect, "tracks", $"{code}.mp3");

            return File(System.IO.File.OpenRead(path), "audio/mp3", true);
        }

        [HttpPost("add")]
        public async Task<IActionResult> AddTrack([FromForm] AddFileModelRequest request)
        {
            if (request.File != null && request.File.Length > 0)
            {
                var wwwroot = environment.WebRootPath;
                var fileName = request.File.FileName;

                var path = Path.Combine(wwwroot, "tracks", $"{fileName}.mp3");

                using (var fileStream = new FileStream(path, FileMode.Create))
                {
                    await request.File.CopyToAsync(fileStream);
                }

                return Ok();
            }

            return BadRequest();
        }
    }
}
