using Hyperai.Events;
using Hyperai.Messages;
using Hyperai.Messages.ConcreteModels;
using Hyperai.Receipts;
using Hyperai.Relations;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Hyperai.Services
{
    public static class ApiClientExtensions
    {
        public static IApiClient On<T>(this IApiClient client, Action<IApiClient, T> action) where T : GenericEventArgs
        {
            client.On(new DefaultEventHandler<T>(client, action));
            return client;
        }

        public static async Task<MessageReceipt> SendFriendMessageAsync(this IApiClient client, Friend friend, MessageChain message)
        {
            FriendMessageEventArgs args = new FriendMessageEventArgs()
            {
                Message = message,
                User = friend
            };
            return ((MessageReceipt)await client.SendAsync(args));
        }

        public static async Task<MessageReceipt> SendGroupMessageAsync(this IApiClient client, Group group, MessageChain message)
        {
            GroupMessageEventArgs args = new GroupMessageEventArgs()
            {
                Message = message,
                Group = group
            };
            return ((MessageReceipt)await client.SendAsync(args));
        }

        public static async Task RevokeMessageAsync(this IApiClient client, long messageId)
        {
            RecallEventArgs args = new RecallEventArgs()
            {
                MessageId = messageId,
            };
            await client.SendAsync(args);
        }

        public static async Task Kick(this IApiClient client, Group group, Member member)
        {
            GroupMemberLeftEventArgs args = new GroupMemberLeftEventArgs()
            {
                Group = group,
                IsKicked = true,
                Who = member
            };
            await client.SendAsync(args);
        }

        public static async Task Quit(this IApiClient client, Group group)
        {
            GroupSelfLeftEventArgs args = new GroupSelfLeftEventArgs()
            {
                Group = group,
                IsKicked = false,
            };
            await client.SendAsync(args);
        }

        public static async Task Mute(this IApiClient client, Group group, Member member, TimeSpan duration)
        {
            GroupMemberMutedEventArgs args = new GroupMemberMutedEventArgs()
            {
                Group = group,
                Whom = member,
                Duration = duration
            };
            await client.SendAsync(args);
        }

        public static async Task MuteAll(this IApiClient client, Group group, TimeSpan duration)
        {
            GroupAllMutedEventArgs args = new GroupAllMutedEventArgs()
            {
                Group = group,
                IsEnded = false,
                Duration = duration
            };
            await client.SendAsync(args);
        }
    }
}