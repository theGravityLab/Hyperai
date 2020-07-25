using Hyperai.Relations;

namespace Hyperai.Events
{
    public class GroupMemberPermissionChangedEventArgs : GroupPermissionChangedEventArgs
    {
        public Member Whom { get; set; }
    }
}