using System;

namespace Hyperai.Messages.ConcreteModels
{
    [Serializable]
    public class Source : MessageComponent
    {
        public long MessageId { get; }

        public Source(long id)
        {
            MessageId = id;
        }
        public override int GetHashCode()
        {
            return MessageId.GetHashCode();
        }

        public override string ToString()
        {
            return $"<SOURCE {MessageId}>";
        }
    }
}
