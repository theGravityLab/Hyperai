using System.Collections.Generic;

namespace Hyperai.Messages
{
    public sealed class MessageChainBuilder : IBuilder<MessageChain>
    {
        private readonly List<MessageElement> components = new();

        public MessageChain Build()
        {
            var chain = new MessageChain(components);
            return chain;
        }

        public MessageChainBuilder Add(MessageElement element)
        {
            components.Add(element);
            return this;
        }
    }
}