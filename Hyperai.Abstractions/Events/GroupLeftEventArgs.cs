using Hyperai.Relations;

namespace Hyperai.Events
{
    public class GroupLeftEventArgs : GenericEventArgs
    {
        public bool IsKicked { get; set; }
        /// <summary>
        /// 当被踢出群聊时该属性为管理员或群主, 当主动退群时该属性为退群者自己
        /// </summary>
        public Member Operator { get; set; }
        public Group Group { get; set; }
    }
}
