namespace Hyperai.Relations
{
    public enum GroupRole
    {
        Owner,
        Member,
        Administrator
    }
    public sealed class Member : User
    {
        public override string Identifier => $"{Identity}@{Group.Identity}";
        /// <summary>
        /// 头衔
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 群名片
        /// </summary>
        public string DisplayName { get; set; }
        /// <summary>
        /// 是否被禁言
        /// </summary>
        public string IsMuted { get; set; }
        /// <summary>
        /// 所在群
        /// </summary>
        public Group Group { get; set; }
        /// <summary>
        /// 所在群中的角色
        /// </summary>
        public GroupRole Role { get; set; }
    }
}
