using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;

namespace Services.Services.FileManager
{
    public class FileManagerService : IFileManagerService
    {
        private readonly HttpClient client;

        public FileManagerService(IConfiguration configuration)
        {
            client = new HttpClient
            {
                BaseAddress = new Uri(configuration["FileManager:url"]),
                Timeout = TimeSpan.FromSeconds(30),
            };
        }

        public async Task<HttpResponseMessage> CreateTrack(IFormFile track, Guid fileName)
        {
            var content = GenerateMultipartFormDataContent(track, fileName);

            return await client.PostAsync("/api/v1/track/add", content);
        }

        private static MultipartFormDataContent GenerateMultipartFormDataContent(IFormFile file, Guid fileName)
        {
            using var fileStream = file.OpenReadStream();
            byte[] bytes = new byte[file.Length];
            fileStream.Read(bytes, 0, (int)file.Length);

            var bytesContent = new ByteArrayContent(bytes);

            return new MultipartFormDataContent
            {
                { bytesContent, "file", fileName.ToString() }
            };
        }
    }
}
