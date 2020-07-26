using System;

namespace Hyperai.Messages.ConcreteModels
{
    [Serializable]
    public class At : MessageComponent
    {
        public long TargetId { get; set; }

        public At(long targetId)
        {
            TargetId = targetId;
        }

        public override int GetHashCode()
        {
            return TargetId.GetHashCode();
        }

        public override string ToString()
        {
            return $"<AT {TargetId}>";
        }
    }
}