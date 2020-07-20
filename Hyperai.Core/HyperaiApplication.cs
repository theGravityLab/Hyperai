using Hyperai.Events;
using Hyperai.Middlewares;
using Hyperai.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Hyperai
{
    public class HyperaiApplication : IHyperaiApplication
    {
        public IReadOnlyList<Type> Middlewares { get; set; }
        public IServiceProvider Provider { get; set; }


        /// <summary>
        /// 创建一个线程并运行 <see cref="Run"/>
        /// </summary>
        public async Task StartAsync()
        {
            await Task.Run(() =>
            {
                IApiClient apiClient = Provider.GetRequiredService<IApiClient>();
                apiClient.Connect();
                apiClient.On<GenericEventArgs>((sender, args) =>
                {
                    using (IServiceScope scope = Provider.CreateScope())
                    {
                        foreach (Type type in Middlewares)
                        {
                            IMiddleware middleware = ActivatorUtilities.CreateInstance(Provider, type) as IMiddleware;
                            if (!middleware.Run(sender, args))
                            {
                                break;
                            }
                        }
                    }
                });
                apiClient.Listen();
            });
        }

        public async Task StopAsync()
        {
            await Task.Run(() =>
            {
                IApiClient apiClient = Provider.GetRequiredService<IApiClient>();
                apiClient.Disconnect();
                ((IDisposable)Provider).Dispose();
            });
        }
    }
}
