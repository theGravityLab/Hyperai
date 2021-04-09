using System;
using Hyperai.Relations;

namespace Hyperai.Events
{
    public abstract class GroupMutedEventArgs : GenericEventArgs
    {
        public TimeSpan Duration { get; set; }
        public Member Operator { get; set; }
        public Group Group { get; set; }
    }
}