using Domain.Exceptions;
using Domain.Helpers;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Services.Services.FileManager.Helpers;
using Services.Services.IdentifiedService;
using System.Net.Http.Headers;

namespace Services.Services.FileManager
{
    public class FileManagerService : IFileManagerService
    {
        private readonly IIdentifiedService identifiedService;
        private readonly HttpClient client;
        private readonly string Key;

        public FileManagerService(FileManagerSettings fileManagerSettings, IIdentifiedService identifiedService)
        {
            this.identifiedService = identifiedService;
            Key = fileManagerSettings.Key;

            client = new HttpClient
            {
                BaseAddress = new Uri(fileManagerSettings.Url),
                Timeout = TimeSpan.FromSeconds(fileManagerSettings.Timeout),
            };
        }

        public async Task CreateTrack(IFormFile track, Guid fileName)
        {
            var url = "/api/v1/tracks/add";

            await PostAsync(track, fileName, url);
        }

        public async Task CreateCover(IFormFile cover, Guid coverName)
        {
            var url = "/api/v1/covers/add";

            await PostAsync(cover, coverName, url);
        }

        public async Task CreatePhoto(IFormFile photo, Guid photoName)
        {
            var url = "/api/v1/photos/add";

            await PostAsync(photo, photoName, url);
        }

        public async Task CreateIcon(IFormFile icon, Guid iconName)
        {
            var url = "/api/v1/icons/add";

            await PostAsync(icon, iconName, url);
        }

        private async Task PostAsync(IFormFile file, Guid fileName, string url)
        {
            var token = identifiedService.GetToken();
            var datetime = DateTime.Now.ToString("yyMMddHHmmss");

            var request = new HttpRequestMessage(HttpMethod.Post, url);

            request.Headers.Add("token", token);
            request.Headers.Add("datetime", datetime);
            request.Headers.Add("hash", HashHelper.Sha256($"{token}:{Key}:{datetime}"));
            request.Content = GenerateMultipartFormDataContent(file, fileName);

            var result = await client.SendAsync(request);

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
