namespace Hyperai.Events
{
    public abstract class RecallEventArgs : GenericEventArgs
    {
        public long WhoseMessage { get; set; }
        public long MessageId { get; set; }
    }
}
