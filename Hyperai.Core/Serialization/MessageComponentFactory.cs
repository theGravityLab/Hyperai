using System;
using Hyperai.Messages;
using Hyperai.Messages.ConcreteModels;

namespace Hyperai.Serialization
{
    public static class MessageComponentFactory
    {
        public static MessageComponent Produce(string name, string code)
        {
            return name.ToLower() switch
            {
                "at" => new At(Convert.ToInt64(code)),
                "atall" => new AtAll(),
                "face" => new Face(Convert.ToInt32(code)),
                "flash" => new Flash(code.Substring(0, code.IndexOf(',')),
                    new Uri(code.Substring(code.IndexOf(',') + 1))),
                "image" => new Image(code.Substring(0, code.IndexOf(',')),
                    new Uri(code.Substring(code.IndexOf(',') + 1))),
                "plain" => new Plain(code),
                "poke" => new Poke(Enum.Parse<PokeType>(code)),
                "quote" => new Quote(Convert.ToInt32(code)),
                "source" => new Source(Convert.ToInt32(code)),

                _ => throw new NotImplementedException()
            };
        }
    }
}