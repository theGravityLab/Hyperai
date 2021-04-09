namespace Hyperai.Events
{
    public class FriendRequestResponsedEventArgs : GenericEventArgs
    {
        public long EventId { get; set; }
        public long FromWhom { get; set; }
        public long FromWhichGroup { get; set; }
        public string MessageToAttach { get; set; }
        public FriendRequestResponseOperationType Operation { get; set; }
    }

    public enum FriendRequestResponseOperationType
    {
        Accepted = 0,
        Refused = 1,
        Banned = 2
    }
}