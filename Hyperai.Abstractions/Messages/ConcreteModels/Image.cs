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

        public override string ToString()
        {
            return $"<IMAGE {ImageId}>";
        }

        public override int GetHashCode()
        {
            return ImageId.GetHashCode();
        }

        public static Image FromUrl(string id, Uri url)
        {
            return new(id, new UrlSource(url));
        }

        public static Image FromStream(string id, Stream stream)
        {
            return new(id, new StreamSource(stream));
        }
    }
}
