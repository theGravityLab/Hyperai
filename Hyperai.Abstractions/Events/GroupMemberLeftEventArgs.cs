using Hyperai.Relations;

namespace Hyperai.Events
{
    public class GroupMemberLeftEventArgs : GroupLeftEventArgs
    {
        public Member Who { get; set; }
    }
}
