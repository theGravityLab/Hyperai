using Hyperai.Relations;

namespace Hyperai.Events
{
    public class GroupMemberMutedEventArgs : GroupMutedEventArgs
    {
        public Member Whom { get; set; }
    }
}
