using System;
using Microsoft.Extensions.DependencyInjection;

namespace Hyperai
{
    public interface IHyperaiApplicationBuilder : IBuilder<IHyperaiApplication>
    {
        IServiceCollection Services { get; }

        void Use(Type middleware);

        void UseStartup<TStartup>() where TStartup : IHyperaiApplicationBuilderStartup, new();
    }
}
