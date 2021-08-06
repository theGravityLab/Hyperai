using Hyperai.Relations;

namespace Hyperai.Events
{
    public class GroupMemberUnmutedEventArgs : GenericEventArgs
    {
        
        public Member Operator { get; set; }
        public Group Group { get; set; }
        public Member Whom { get; set; }
    }
}
