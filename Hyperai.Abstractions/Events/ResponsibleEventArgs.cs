namespace Hyperai.Events
{
    public abstract class ResponsibleEventArgs : GenericEventArgs
    {
        public long EventId { get; set; }
    }
}