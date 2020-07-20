using Hyperai.Relations;

namespace Hyperai.Events
{
    public sealed class GroupMessageEventArgs : MessageEventArgs
    {
        public Member User { get; set; }
        public Group Group { get; set; }
    }
}
