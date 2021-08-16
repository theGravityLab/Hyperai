namespace Hyperai.Messages.ConcreteModels
{
    public class ForwardNode: MessageElement
    {
        public long UserId { get; set; }
        public long UserDisplayName { get; set; }
        public MessageChain Content { get; set; }
        
        public override int GetHashCode()
        {
            throw new System.NotImplementedException();
        }
    }
}
