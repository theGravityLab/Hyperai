using System;

namespace Hyperai.Events
{
    public class GroupSelfMutedEventArgs : GroupMutedEventArgs
    {
        
        public TimeSpan Duration { get; set; }
    }
}
