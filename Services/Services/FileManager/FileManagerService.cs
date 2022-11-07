using Domain.Exceptions;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Services.Services.FileManager.Helpers;
using System.Net.Http.Headers;

namespace Services.Services.FileManager
{
    public class FileManagerService : IFileManagerService
    {
        private readonly HttpClient client;

        public FileManagerService(FileManagerSettings fileManagerSettings)
        {
            client = new HttpClient
            {
                BaseAddress = new Uri(fileManagerSettings.Url),
                Timeout = TimeSpan.FromSeconds(fileManagerSettings.Timeout),
            };
        }

        public async Task CreateTrack(IFormFile track, Guid fileName)
        {
            var url = "/api/v1/track/add";

            await PostAsync(track, fileName, url);
        }

        public async Task CreateCover(IFormFile cover, Guid coverName)
        {
            var url = "/api/v1/cover/add";

            await PostAsync(cover, coverName, url);
        }

        public async Task CreatePhoto(IFormFile photo, Guid photoName)
        {
            var url = "/api/v1/photo/add";

            await PostAsync(photo, photoName, url);
        }

        private async Task PostAsync(IFormFile cover, Guid coverName, string url)
        {
            var formData = GenerateMultipartFormDataContent(cover, coverName);

            var result = await client.PostAsync(url, formData);

            var content = await result.Content.ReadAsStringAsync();

            var response = JsonConvert.DeserializeObject<FileManagerResponse>(content);

            if (response.Status)
                return;

            throw new ValidationException(response.Errors);
        }

        private static MultipartFormDataContent GenerateMultipartFormDataContent(IFormFile file, Guid fileName)
        {
            using var fileStream = file.OpenReadStream();
            byte[] bytes = new byte[file.Length];
            fileStream.Read(bytes, 0, (int)file.Length);

            var bytesContent = new ByteArrayContent(bytes);

            bytesContent.Headers.ContentType = new MediaTypeHeaderValue(file.ContentType);

            return new MultipartFormDataContent
            {
                { bytesContent, "file", fileName.ToString() }
            };
        }
    }
}
