using System.Collections.Generic;

namespace Hyperai.Messages
{
    public sealed class MessageChainBuilder : IBuilder<MessageChain>
    {
        private readonly List<MessageComponent> components = new List<MessageComponent>();

        public MessageChain Build()
        {
            MessageChain chain = new MessageChain(components.AsReadOnly());
            return chain;
        }

        public MessageChainBuilder Add(MessageComponent component)
        {
            components.Add(component);
            return this;
        }
    }
}