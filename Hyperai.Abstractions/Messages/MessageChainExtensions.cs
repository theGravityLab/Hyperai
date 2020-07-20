using Hyperai.Messages.ConcreteModels;
using System;
using System.Linq;
using System.Reflection;

namespace Hyperai.Messages
{
    public static class MessageChainExtensions
    {
        public static MessageChain AsReadable(this MessageChain chain)
        {
            return new MessageChain(chain.components.Where(x => !(x is Source) && x.GetType().GetCustomAttribute<SerializableAttribute>() != null), chain.MessageId);
        }
    }
}
