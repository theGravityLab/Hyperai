namespace Hyperai.Messages.ConcreteModels
{
    public class ContentBase : MessageComponent
    {
        public string Content { get; protected set; }

        public override int GetHashCode()
        {
            return Content.GetHashCode();
        }
    }
}