using dotnetCampus.Cli;

namespace Youtube.Get
{
    public class ArgsOptions
    {
        [Value(0), Option("url")]
        public string Url { get; }

        [Option("id")]
        public string Id { get; }

        [Option('o', "output")]
        public string OutputFilePath { get; }

        public ArgsOptions(string url, string id, string filePath)
        {
            Url = url;
            Id = id;
            OutputFilePath = filePath;
        }
    }
}
