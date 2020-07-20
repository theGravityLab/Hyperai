using Hyperai.Relations;

namespace Hyperai.Events
{
    public class GroupMemberTitleChangedEventArgs : GenericEventArgs
    {
        public string Original { get; set; }
        public string Present { get; set; }
        public Group Group { get; set; }
        public Member Who { get; set; }
    }
}
