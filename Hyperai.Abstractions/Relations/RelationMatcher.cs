using Hyperai.Events;

namespace Hyperai.Relations
{
    public class RelationMatcher
    {
        public string Expression { get; set; }
        public long Destination { get; set; }

        public RelationMatcher(string expression)
        {
            Expression = expression;
        }

        public bool Match(Member member)
        {
            string prefix = Expression.Substring(0,Expression.IndexOf(':'));
            string postfix = Expression.Substring(prefix.Length + 1);

            if (prefix == "*")
            {
                if (long.TryParse(postfix, out long result))
                {
                    return result == member.Identity;
                }
                
                return false;
            }
            else
            {
                return prefix == member.Group.Value.Identity.ToString() && (postfix == "*" ||
                                                                 (member.Group.Value.Identity.ToString() == prefix &&
                                                                  member.Identity.ToString() == postfix));
            }
        }

        public bool Match(Friend friend)
        {
            string prefix = Expression.Substring(0,Expression.IndexOf(':'));
            string postfix = Expression.Substring(prefix.Length + 1);

            if (prefix == "*")
            {
                return false;
            }
            if (prefix == "_")
            {
                if (long.TryParse(postfix, out long result))
                {
                    return result == friend.Identity;
                }

                return postfix == "*";
            }

            return false;
        }

        public static RelationMatcher FromGroup(long groupId)
        {
            return new RelationMatcher($"{groupId}:*");
        }

        public static RelationMatcher FromMember(long groupId, long memberId)
        {
            return new RelationMatcher($"{groupId}:{memberId}");
        }

        public static RelationMatcher FromAnyGroup(long userId)
        {
            return new RelationMatcher($"*:{userId}");
        }
        
        public static RelationMatcher FromAnyGroupAnyMember()
        {
            return new RelationMatcher($"*:*");
        }

        public static RelationMatcher FromFriend(long friendId)
        {
            return new RelationMatcher($"_:{friendId}");
        }

        public static RelationMatcher FromAnyFriend()
        {
            return new RelationMatcher("_:*");
        }
    }
}
