namespace Hyperai.Messages.ConcreteModels
{
    public class ContentBase : MessageComponent
    {
        public string Content { get; set; }

        public override int GetHashCode()
        {
            return Content.GetHashCode();
        }
    }
}