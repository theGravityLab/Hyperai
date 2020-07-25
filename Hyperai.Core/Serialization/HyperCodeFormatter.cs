using Hyperai.Messages;
using Hyperai.Messages.ConcreteModels;
using System;
using System.Linq;
using System.Reflection;

namespace Hyperai.Serialization
{
    public class HyperCodeFormatter : IMessageChainFormatter
    {
        public string Format(MessageChain chain)
        {
            return string.Join(string.Empty, chain.Where(x => x.GetType().GetCustomAttribute<SerializableAttribute>() != null).Select(x => PlainSelector(x)));

            string PlainSelector(MessageComponent comp)
            {
                return comp switch
                {
                    Plain it => it.Text,
                    _ => $"[hyper.{comp.TypeName.ToLower()}({CodeSelector(comp)})]"
                };
            }

            string CodeSelector(MessageComponent comp)
            {
                return comp switch
                {
                    At it => it.TargetId.ToString(),
                    AtAll it => string.Empty,
                    Face it => it.FaceId.ToString(),
                    ImageBase it => $"{it.ImageId},{it.Url}",
                    Poke it => it.Name.ToString(),
                    Quote it => it.MessageId.ToString(),
                    Source it => it.MessageId.ToString(),

                    _ => throw new NotImplementedException()
                };
            }
        }
    }
}