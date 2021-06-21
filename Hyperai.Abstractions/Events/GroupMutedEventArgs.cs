using Hyperai.Relations;

namespace Hyperai.Events
{
    public abstract class GroupMutedEventArgs : GenericEventArgs
    {
        public Member Operator { get; set; }
        public Group Group { get; set; }
    }
}
