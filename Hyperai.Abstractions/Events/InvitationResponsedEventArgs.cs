namespace Hyperai.Events
{
    public class InvitationResponsedEventArgs : GenericEventArgs
    {
        public long EventId { get; set; }
        public long Operator { get; set; }
        public long IntoWhichGroup { get; set; }
        public string MessageToAttach { get; set; }
        public InvitationResponseOperationType Operation { get; set; }
    }

    public enum InvitationResponseOperationType
    {
        Accepted = 0,
        Refuse = 1
    }
}