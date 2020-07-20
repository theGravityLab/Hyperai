using Hyperai.Events;
using System;
using System.Threading.Tasks;

namespace Hyperai.Services
{
    public interface IApiClient : IDisposable
    {
        ApiClientConnectionState State { get; }
        void Listen();
        void Connect();
        void Disconnect();
        Task<T> RequestAsync<T>(T model);
        [Obsolete]
        string RequestRawAsync(string resource);
        void On<T>(IEventHandler<T> handler) where T : GenericEventArgs;
        Task SendAsync<T>(T args) where T : MessageEventArgs;
        [Obsolete]
        void SendRawAsync(string resource);
    }
}
