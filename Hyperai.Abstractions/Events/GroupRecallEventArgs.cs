﻿using Hyperai.Relations;

namespace Hyperai.Events
{
    public class GroupRecallEventArgs : RecallEventArgs
    {
        public Member WhoseMessage { get; set; }
        public Group Group { get; set; }
        public Member Operator { get; set; }
    }
}
