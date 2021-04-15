using System;
using Hyperai.Messages.ConcreteModels.ImageSources;

namespace Hyperai.Messages.ConcreteModels
{
    [Serializable]
    public class Flash : ImageBase
    {
        public Flash(string imageId, IImageSource source)
        {
            ImageId = imageId;
            Source = source;
        }

        public override string ToString() =>
            $"<FLASH {ImageId}>";

        public override int GetHashCode() => 
            ImageId.GetHashCode();
    }
}