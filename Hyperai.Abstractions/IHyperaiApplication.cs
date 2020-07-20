using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Hyperai
{
    public interface IHyperaiApplication
    {
        IReadOnlyList<Type> Middlewares { get; set; }
        IServiceProvider Provider { get; set; }
        Task StartAsync();

        Task StopAsync();
    }
}
