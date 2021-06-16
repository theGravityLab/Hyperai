using System;
using Hyperai.Messages;
using Hyperai.Messages.ConcreteModels;
using Hyperai.Messages.ConcreteModels.ImageSources;

namespace Hyperai.Serialization
{
    public static class MessageElementFactory
    {
        public static MessageElement Produce(string name, string code)
        {
            return name.ToLower() switch
            {
                "at" => new At(Convert.ToInt64(code)),
                "atall" => new AtAll(),
                "face" => new Face(Convert.ToInt32(code)),
                "flash" => new Flash(code.Substring(0, code.IndexOf(',')),
                    new UrlSource(new Uri(code.Substring(code.IndexOf(',') + 1), UriKind.Absolute))),
                "image" => new Image(code.Substring(0, code.IndexOf(',')),
                    new UrlSource(new Uri(code.Substring(code.IndexOf(',') + 1), UriKind.Absolute))),
                "plain" => new Plain(code),
                "poke" => new Poke(Enum.Parse<PokeType>(code)),
                "quote" => new Quote(Convert.ToInt32(code)),
                "source" => new Source(Convert.ToInt32(code)),

                _ => throw new NotImplementedException()
            };
        }
    }
}
