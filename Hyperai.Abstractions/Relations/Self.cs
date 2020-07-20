using System.Collections.Generic;

namespace Hyperai.Relations
{
    public sealed class Self : User
    {
        public override string Identifier => Identity.ToString();
        public IEnumerable<Group> Groups { get; set; }
        public IEnumerable<Friend> Friends { get; set; }
    }
}
