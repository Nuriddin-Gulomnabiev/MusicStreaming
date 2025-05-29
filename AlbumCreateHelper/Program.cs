using System.Net.Http.Headers;
using System.Globalization;

class Program
{
    static async Task Main()
    {
        while (true)
        {
            Console.Write("Введите имя артиста: ");
            var artistName = Console.ReadLine();

            Console.Write("Введите название альбома: ");
            var albumName = Console.ReadLine();

            Console.Write("Введите дату релиза (yyyy-MM-dd): ");
            var releaseDateInput = Console.ReadLine();

            if (!DateTime.TryParseExact(releaseDateInput, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out var releaseDate))
            {
                Console.WriteLine("Неверный формат даты. Используйте формат yyyy-MM-dd.");
                return;
            }

            var musicFolder = Path.Combine(Directory.GetCurrentDirectory(), "music"); // например, ./music
            if (!Directory.Exists(musicFolder))
            {
                Console.WriteLine($"Папка с треками не найдена: {musicFolder}");
                return;
            }

            var mp3Files = Directory.GetFiles(musicFolder, "*.mp3");
            if (mp3Files.Length == 0)
            {
                Console.WriteLine("В папке нет mp3 файлов.");
                return;
            }

            using var httpClient = new HttpClient();
            using var form = new MultipartFormDataContent();

            form.Add(new StringContent(artistName), "ArtistName");
            form.Add(new StringContent(albumName), "AlbumName");
            form.Add(new StringContent(releaseDate.ToString("yyyy-MM-dd")), "ReleaseDate");

            int index = 0;
            foreach (var filePath in mp3Files)
            {
                var trackName = Path.GetFileNameWithoutExtension(filePath);
                var fileContent = new StreamContent(File.OpenRead(filePath));
                fileContent.Headers.ContentType = new MediaTypeHeaderValue("audio/mpeg");

                form.Add(new StringContent(trackName), $"Tracks[{index}].Name");
                form.Add(fileContent, $"Tracks[{index}].Track", Path.GetFileName(filePath));

                index++;
            }

            try
            {
                var url = "https://localhost:7268/api/v1/albums/create/full"; // Укажите ваш настоящий адрес
                var response = await httpClient.PostAsync(url, form);

                var result = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"Ответ от сервера: {response.StatusCode} - {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Message: {ex.Message}");

                if (ex.InnerException != null)
                    Console.WriteLine($"Message: {ex.InnerException.Message}");
            }
        }
    }
}
