using System;
using System.Collections.Generic;
using Hyperai.Middlewares;
using Microsoft.Extensions.DependencyInjection;

namespace Hyperai
{
    public class HyperaiApplicationBuilder : IHyperaiApplicationBuilder
    {
        private readonly List<Type> middlewares = new();
        private Type typeStartup;
        public IServiceCollection Services { get; } = new ServiceCollection();

        public void UseStartup<TStartup>() where TStartup : IHyperaiApplicationBuilderStartup, new()
        {
            typeStartup = typeof(TStartup);
        }

        public IHyperaiApplication Build()
        {
            var startup = (IHyperaiApplicationBuilderStartup) Activator.CreateInstance(typeStartup, false);
            startup!.ConfigureServices(Services);
            startup!.ConfigureMiddlewares(this);
            var app = new HyperaiApplication
                {Provider = Services.BuildServiceProvider(), Middlewares = middlewares.AsReadOnly()};
            return app;
        }

        public void Use(Type middleware)
        {
            if (!typeof(IMiddleware).IsAssignableFrom(middleware))
                throw new ArgumentException("Type should implements IMiddleware interface.");
            middlewares.Add(middleware);
        }
    }
}