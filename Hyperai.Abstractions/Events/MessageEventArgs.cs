using Hyperai.Messages;

namespace Hyperai.Events
{
    public abstract class MessageEventArgs : GenericEventArgs
    {
        public MessageChain Message { get; set; }
    }
}