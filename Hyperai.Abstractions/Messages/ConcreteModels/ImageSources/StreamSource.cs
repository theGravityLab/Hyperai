using System;
using System.IO;

namespace Hyperai.Messages.ConcreteModels.ImageSources
{
    public sealed class StreamSource : IImageSource, IDisposable
    {
        public StreamSource(Stream from)
        {
            Data = from;
        }

        public Stream Data { get; set; }

        public void Dispose()
        {
            Data?.Dispose();
        }

        public Stream OpenRead()
        {
            return Data;
        }
    }
}
