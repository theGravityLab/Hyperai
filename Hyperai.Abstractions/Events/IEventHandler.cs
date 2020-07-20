namespace Hyperai.Events
{
    public interface IEventHandler<T> where T : GenericEventArgs
    {
        void Handle(T args);
    }
}
