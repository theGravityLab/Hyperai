using Hyperai.Relations;

namespace Hyperai.Events
{
    public class GroupAllMutedEventArgs : GenericEventArgs
    {
        public Member Operator { get; set; }
        public Group Group { get; set; }
        public bool IsEnded { get; set; }
    }
}
