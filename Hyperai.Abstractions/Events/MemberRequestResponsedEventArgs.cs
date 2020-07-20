namespace Hyperai.Events
{
    public class MemberRequestResponsedEventArgs : GenericEventArgs
    {
        public long EventId { get; set; }
        public long FromWhom { get; set; }
        public long InWhichGroup { get; set; }
        public string MessageToAttach { get; set; }
        public MemberRequestResponseOperationType Operation { get; set; }
    }


    public enum MemberRequestResponseOperationType
    {
        Accepted = 0,
        Refused = 1,
        Ignored = 2,
        RefusedAndBanned = 3,
        IgnoredAndBanned = 4
    }
}
