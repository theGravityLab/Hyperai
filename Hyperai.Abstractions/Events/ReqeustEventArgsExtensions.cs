using System;

namespace Hyperai.Events
{
    public static class ReqeustEventArgsExtensions
    {
        public static FriendRequestResponsedEventArgs MakeResponse(this FriendRequestEventArgs args, FriendRequestResponseOperationType action = FriendRequestResponseOperationType.Accepted, string message = "")
        {
            return new FriendRequestResponsedEventArgs()
            {
                EventId = args.EventId,
                FromWhom = args.FromWhom,
                FromWhichGroup = args.FromWhichGroup,
                MessageToAttach = message,
                Operation = action,
                Time = DateTime.Now
            };
        }

        public static MemberRequestResponsedEventArgs MakeResponse(this GroupMemberRequestEventArgs args, MemberRequestResponseOperationType action = MemberRequestResponseOperationType.Accepted, string message = "")
        {
            return new MemberRequestResponsedEventArgs()
            {
                EventId = args.EventId,
                FromWhom = args.FromWhom,
                InWhichGroup = args.InWhichGroup,
                MessageToAttach = message,
                Operation = action,
                Time = DateTime.Now
            };
        }

        public static InvitationResponsedEventArgs MakeResponse(this SelfInvitedIntoGroupEventArgs args, InvitationResponseOperationType action = InvitationResponseOperationType.Accepted, string message = "")
        {
            return new InvitationResponsedEventArgs()
            {
                EventId = args.EventId,
                IntoWhichGroup = args.IntoWhichGroup,
                Operator = args.OperatorId,
                MessageToAttach = message,
                Operation = action,
                Time = DateTime.Now
            };
        }
    }
}
