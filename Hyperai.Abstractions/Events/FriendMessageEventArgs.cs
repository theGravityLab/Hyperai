using Hyperai.Relations;

namespace Hyperai.Events
{
    public sealed class FriendMessageEventArgs : MessageEventArgs
    {
        public Friend User { get; set; }
    }
}