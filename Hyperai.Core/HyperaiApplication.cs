using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Hyperai.Events;
using Hyperai.Middlewares;
using Hyperai.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Hyperai
{
    public class HyperaiApplication : IHyperaiApplication
    {
        public IReadOnlyList<Type> Middlewares { get; set; }
        public IServiceProvider Provider { get; set; }

        /// <summary>
        ///     创建一个线程并运行
        /// </summary>
        public async Task StartAsync()
        {
            await Task.Run(() =>
            {
                var apiClient = Provider.GetRequiredService<IApiClient>();
                apiClient.Connect();
                apiClient.On<GenericEventArgs>((sender, args) =>
                {
                    using var scope = Provider.CreateScope();
                    foreach (var type in Middlewares)
                    {
                        var middleware = ActivatorUtilities.CreateInstance(Provider, type) as IMiddleware;
                        if (!middleware!.Run(sender, args)) break;
                    }
                });
                apiClient.Listen();
            });
        }

        public async Task StopAsync()
        {
            await Task.Run(() =>
            {
                var apiClient = Provider.GetRequiredService<IApiClient>();
                apiClient.Disconnect();
                ((IDisposable) Provider).Dispose();
            });
        }
    }
}