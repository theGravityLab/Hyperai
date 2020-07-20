using Hyperai.Events;
using Hyperai.Messages;
using Hyperai.Relations;
using System;
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

        public static async Task SendFriendMessageAsync(this IApiClient client, Friend friend, MessageChain message)
        {
            FriendMessageEventArgs args = new FriendMessageEventArgs()
            {
                Message = message,
                User = friend,
                Time = DateTime.Now
            };
            await client.SendAsync(args);
        }

        public static async Task SendGroupMessageAsync(this IApiClient client, Group group, MessageChain message)
        {
            GroupMessageEventArgs args = new GroupMessageEventArgs()
            {
                Message = message,
                Group = group,
                Time = DateTime.Now
            };
            await client.SendAsync(args);
        }
    }
}
