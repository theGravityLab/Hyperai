using System.IO;
using Hyperai.Messages.ConcreteModels.ImageSources;

namespace Hyperai.Messages.ConcreteModels
{
    public abstract class ImageBase : MessageElement
    {
        public string ImageId { get; set; }

        public IImageSource Source { get; set; }

        public Stream OpenRead()
        {
            return Source.OpenRead();
        }
    }
}
