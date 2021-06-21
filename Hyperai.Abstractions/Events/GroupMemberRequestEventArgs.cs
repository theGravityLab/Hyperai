namespace Hyperai.Events
{
    public class GroupMemberRequestEventArgs : GenericEventArgs
    {
        public long EventId { get; set; }
        public long FromWhom { get; set; }
        public long InWhichGroup { get; set; }
        public string DisplayName { get; set; }
        public string GroupDisplayName { get; set; }
        public string AttachedMessage { get; set; }
    }
}
