namespace Hyperai
{
    public interface IBuilder<out T>
    {
        T Build();
    }
}