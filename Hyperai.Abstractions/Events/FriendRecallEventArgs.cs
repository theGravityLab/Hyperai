using Hyperai.Relations;

namespace Hyperai.Events
{
    public class FriendRecallEventArgs : RecallEventArgs
    {
        public Friend WhoseMessage { get; set; }
    }
}
