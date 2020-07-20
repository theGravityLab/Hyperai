using Hyperai.Relations;

namespace Hyperai.Events
{
    public class GroupMemberCardChangedEventArgs : GenericEventArgs
    {
        public string Original { get; set; }
        public string Present { get; set; }
        public Member Operator { get; set; }
        public Member WhoseName { get; set; }
        public Group Group { get; set; }
        public bool IsSelfOperated { get; set; }
    }
}
