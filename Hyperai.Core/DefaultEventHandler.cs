using Hyperai.Events;
using Hyperai.Services;
using System;

namespace Hyperai
{
    public class DefaultEventHandler : IEventHandler<GenericEventArgs>
    {
        private readonly IApiClient _client;
        private readonly Action<IApiClient, GenericEventArgs> _action;
        public DefaultEventHandler(IApiClient client, Action<IApiClient, GenericEventArgs> action)
        {
            _client = client;
            _action = action;
        }
        public void Handle(GenericEventArgs args)
        {
            _action(_client, args);
        }
    }
}
