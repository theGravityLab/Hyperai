using System;
using Hyperai.Relations;

namespace Hyperai.Events
{
    public class GroupMemberMutedEventArgs : GroupMutedEventArgs
    {
        public TimeSpan Duration { get; set; }
        public Member Whom { get; set; }
    }
}
