using Hyperai.Relations;

namespace Hyperai.Events
{
    public abstract class GroupJoinedEventArgs : GenericEventArgs
    {
        public Group Group { get; set; }
    }
}
