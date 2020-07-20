namespace Hyperai.Events
{
    public class FriendRecallEventArgs : RecallEventArgs
    {
        public long Operator { get; set; }
        public bool IsSelfOperated { get; set; }
    }
}
