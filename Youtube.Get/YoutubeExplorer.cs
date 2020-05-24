using System;
using System.IO;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Videos.Streams;

namespace Youtube.Get
{
    public class YoutubeExplorer
    {
        private YoutubeClient _client;

        public YoutubeExplorer()
        {
            _client = new YoutubeClient();
        }

        public async Task<bool> DownloadVideoAsync(string videoIdOrUrl, string saveFolder)
        {
            try
            {
                var streams = await _client.Videos.Streams.GetManifestAsync(videoIdOrUrl);

                var streamInfo = streams.GetMuxed().WithHighestVideoQuality();
                if (streamInfo == null)
                {
                    Console.Error.WriteLine("This videos has no streams");
                    return false;
                }

                var filePath = Path.Combine(saveFolder, $"test.{streamInfo.Container.Name}");
                Console.Write($"Downloading stream: {streamInfo.VideoQualityLabel} / {streamInfo.Container.Name}... ");
                using (var progress = new InlineProgress())
                    await _client.Videos.Streams.DownloadAsync(streamInfo, filePath, progress);

                Console.WriteLine($"Video saved to '{filePath}'");

                return true;
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e);
                return false;
            }
            
        }
    }
}
