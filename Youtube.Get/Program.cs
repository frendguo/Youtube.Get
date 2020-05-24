using dotnetCampus.Cli;
using System;
using System.IO;
using System.Threading.Tasks;

namespace Youtube.Get
{
    class Program
    {
        private static readonly string DefaultSaveFolder = 
            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop));

        static async Task Main(string[] args)
        {
            var commandLine = CommandLine.Parse(args);

            var options = commandLine.As<ArgsOptions>();

            if (!string.IsNullOrEmpty(options.Url))
            {
                var explorer = new YoutubeExplorer();
                await explorer.DownloadVideoAsync(options.Url, DefaultSaveFolder);
            }

            Console.ReadLine();
        }
    }
}
