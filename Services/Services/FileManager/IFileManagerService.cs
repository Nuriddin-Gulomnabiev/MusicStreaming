using Microsoft.AspNetCore.Http;

namespace Services.Services.FileManager
{
    public interface IFileManagerService
    {
        Task CreateTrack(IFormFile track, Guid fileName);
        Task CreateCover(IFormFile cover, Guid coverName);
        Task CreatePhoto(IFormFile photo, Guid photoName);
    }
}
