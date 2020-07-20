namespace Hyperai.Events
{
    public class SelfInvitedIntoGroupEventArgs : ResponsibleEventArgs
    {
        public long OperatorId { get; set; }
        public long IntoWhichGroup { get; set; }
        public string GroupDisplayName { get; set; }
        public string OperatorDisplayName { get; set; }
        public string AttachedMessage { get; set; }
    }
}
