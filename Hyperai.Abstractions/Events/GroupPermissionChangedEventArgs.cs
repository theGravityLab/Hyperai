using Hyperai.Relations;

namespace Hyperai.Events
{
    public abstract class GroupPermissionChangedEventArgs : GenericEventArgs
    {
        public GroupRole Original { get; set; }
        public GroupRole Present { get; set; }
        public Group Group { get; set; }
    }
}
