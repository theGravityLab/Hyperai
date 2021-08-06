using Hyperai.Relations;

namespace Hyperai.Events
{
    public class GroupJoinedEventArgs : GenericEventArgs
    {
        public Member Who { get; set; }
        public Group Group { get; set; }
        public Member Operator { get; set; }
    }
}
