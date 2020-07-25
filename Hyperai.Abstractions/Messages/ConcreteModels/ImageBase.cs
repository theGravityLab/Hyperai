using System;
using System.IO;
using System.Net;

namespace Hyperai.Messages.ConcreteModels
{
    public abstract class ImageBase : MessageComponent
    {
        public string ImageId { get; set; }
        public bool IsRemote => Url.Scheme.Equals("https", StringComparison.OrdinalIgnoreCase) || Url.Scheme.Equals("http", StringComparison.OrdinalIgnoreCase);

        public Uri Url { get; set; }

        public virtual Stream OpenRead()
        {
            return Url.Scheme switch
            {
                string it when it == "http" || it == "https" => WebRequest.Create(Url).GetResponse().GetResponseStream(),
                "file" => File.OpenRead(Url.LocalPath),
                _ => throw new NotImplementedException()
            };
        }
    }
}