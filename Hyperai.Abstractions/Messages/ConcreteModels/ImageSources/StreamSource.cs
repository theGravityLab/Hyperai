using System;
using System.IO;

namespace Hyperai.Messages.ConcreteModels.ImageSources
{
    public sealed class StreamSource: IImageSource, IDisposable
    {
        public Stream Data { get; set; }

        public StreamSource(Stream from) => Data = from;
        
        public Stream OpenRead()
        {
            return Data;
        }

        public void Dispose()
        {
            Data?.Dispose();
        }
    }
}