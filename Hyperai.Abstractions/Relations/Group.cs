using System.Collections.Generic;

namespace Hyperai.Relations
{
    public sealed class Group : RelationModel
    {
        public override string Identifier => Identity.ToString();
        public string Name { get; set; }
        public IEnumerable<Member> Members { get; set; }
        public Member Owner { get; set; }
    }
}
