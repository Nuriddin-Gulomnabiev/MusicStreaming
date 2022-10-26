using Microsoft.AspNetCore.Http;

namespace Services.Services.FileManager
{
    public interface IFileManagerService
    {
        Task<HttpResponseMessage> CreateTrack(IFormFile track, Guid fileName);
    }
}
