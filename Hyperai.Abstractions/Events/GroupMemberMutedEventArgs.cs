using System;
using Hyperai.Relations;

namespace Hyperai.Events
{
    public class GroupMemberMutedEventArgs : GenericEventArgs
    {
        public Member Operator { get; set; }
        public Group Group { get; set; }
        public TimeSpan Duration { get; set; }
        public Member Whom { get; set; }
    }
}
