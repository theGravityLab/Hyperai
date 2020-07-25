using Hyperai.Relations;

namespace Hyperai.Events
{
    public class GroupRecallEventArgs : RecallEventArgs
    {
        public Group Group { get; set; }
        public Member Operator { get; set; }
    }
}