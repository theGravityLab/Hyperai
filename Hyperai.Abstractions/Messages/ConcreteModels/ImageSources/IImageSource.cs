using System.IO;

namespace Hyperai.Messages.ConcreteModels.ImageSources
{
    public interface IImageSource
    {
        Stream OpenRead();
    }
}
