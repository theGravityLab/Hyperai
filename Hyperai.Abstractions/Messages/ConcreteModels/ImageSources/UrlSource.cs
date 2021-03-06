using System;
using System.IO;
using System.Net;

namespace Hyperai.Messages.ConcreteModels.ImageSources
{
    public class UrlSource : IImageSource
    {
        public UrlSource(Uri url)
        {
            Url = url;
        }

        public UrlSource(string url)
        {
            Url = new Uri(url, UriKind.Absolute);
        }

        public Uri Url { get; set; }

        public bool IsRemote => Url.Scheme.Equals("https", StringComparison.OrdinalIgnoreCase) ||
                                Url.Scheme.Equals("http", StringComparison.OrdinalIgnoreCase);

        public Stream OpenRead()
        {
            return Url.Scheme switch
            {
                var it when it == "http" || it == "https" =>
                    WebRequest.Create(Url).GetResponse().GetResponseStream(),
                "file" => File.OpenRead(Url.LocalPath),
                _ => throw new NotImplementedException()
            };
        }
    }
}
