using System.Collections.Generic;

namespace Hyperai.Messages
{
    public sealed class MessageChainBuilder : IBuilder<MessageChain>
    {
        private readonly List<MessageComponent> components = new();

        public MessageChain Build()
        {
            var chain = new MessageChain(components);
            return chain;
        }

        public MessageChainBuilder Add(MessageComponent component)
        {
            components.Add(component);
            return this;
        }
    }
}