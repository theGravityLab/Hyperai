using Hyperai.Relations;

namespace Hyperai.Events
{
    public class GroupLeftEventArgs : GenericEventArgs
    {
        
        public Member Who { get; set; }
        public bool IsKicked { get; set; }
        public Member Operator { get; set; }

        public Group Group { get; set; }
    }
}
