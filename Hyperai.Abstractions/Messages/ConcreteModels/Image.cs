using System;

namespace Hyperai.Messages.ConcreteModels
{
    [Serializable]
    public class Image : ImageBase
    {
        public Image(string id, Uri res)
        {
            ImageId = id;
            Url = res;
        }

        public override string ToString()
        {
            return $"<IMAGE {ImageId}>";
        }

        public override int GetHashCode()
        {
            return ImageId.GetHashCode();
        }
    }
}