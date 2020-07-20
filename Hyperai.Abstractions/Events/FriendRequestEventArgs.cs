namespace Hyperai.Events
{
    public class FriendRequestEventArgs : ResponsibleEventArgs
    {
        public long FromWhom { get; set; }
        public long FromWhichGroup { get; set; }
        public string DisplayName { get; set; }
        public string AttachedMessage { get; set; }

        public bool IsFromGroup =>
            FromWhichGroup == 0;
    }
}
