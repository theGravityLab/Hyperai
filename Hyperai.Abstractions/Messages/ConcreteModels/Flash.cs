using System;

namespace Hyperai.Messages.ConcreteModels
{
    [Serializable]
    public class Flash : ImageBase
    {
        public Flash(string imageId, Uri url)
        {
            ImageId = imageId;
            Url = url;
        }

        public override string ToString()
        {
            return $"<FLASH {Url}>";
        }

        public override int GetHashCode()
        {
            return ImageId.GetHashCode();
        }
    }
}
