using Hyperai.Relations;

namespace Hyperai.Events
{
    public abstract class GroupUnmutedEventArgs : GenericEventArgs
    {
        public Member Operator { get; set; }
        public Group Group { get; set; }
    }
}
