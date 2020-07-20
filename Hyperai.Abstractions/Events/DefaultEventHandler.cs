using Hyperai.Services;
using System;

namespace Hyperai.Events
{
    public class DefaultEventHandler<T> : IEventHandler<T> where T : GenericEventArgs
    {
        private readonly IApiClient _client;
        private readonly Action<IApiClient, T> _action;
        public DefaultEventHandler(IApiClient client, Action<IApiClient, T> action)
        {
            _client = client;
            _action = action;
        }
        public void Handle(T args)
        {
            _action(_client, args);
        }
    }
}
