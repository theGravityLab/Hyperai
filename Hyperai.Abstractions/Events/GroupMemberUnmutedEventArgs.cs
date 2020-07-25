using Hyperai.Relations;

namespace Hyperai.Events
{
    public class GroupMemberUnmutedEventArgs : GroupUnmutedEventArgs
    {
        public Member Whom { get; set; }
    }
}