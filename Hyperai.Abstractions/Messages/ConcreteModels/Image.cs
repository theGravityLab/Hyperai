using System;
using System.IO;
using Hyperai.Messages.ConcreteModels.ImageSources;

namespace Hyperai.Messages.ConcreteModels
{
    [Serializable]
    public class Image : ImageBase
    {
        public Image(string id, IImageSource source)
        {
            ImageId = id;
            Source = source;
        }

        public override string ToString() =>
            $"<IMAGE {ImageId}>";

        public override int GetHashCode() =>
            ImageId.GetHashCode();

        public static Image FromUrl(string id, Uri url) => 
            new (id, new UrlSource(url));

        public static Image FromStream(string id, Stream stream) =>
            new(id, new StreamSource(stream));
    }
}