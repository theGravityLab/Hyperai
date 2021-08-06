using Hyperai.Relations;

namespace Hyperai.Events
{
    public class GroupPermissionChangedEventArgs : GenericEventArgs
    {
        public Member Whom { get; set; }
        public GroupRole Original { get; set; }
        public GroupRole Present { get; set; }
        public Group Group { get; set; }
    }
}
