using Hyperai.Middlewares;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;

namespace Hyperai
{
    public class HyperaiApplicationBuilder : IHyperaiApplicationBuilder
    {
        public IServiceCollection Services { get; } = new ServiceCollection();

        private readonly List<Type> middlewares = new List<Type>();
        private Type typeStartup;
        public void UseStartup<TStartup>() where TStartup : IHyperaiApplicationBuilderStartup, new()
        {
            typeStartup = typeof(TStartup);
        }
        public IHyperaiApplication Build()
        {
            IHyperaiApplicationBuilderStartup startup = (IHyperaiApplicationBuilderStartup)Activator.CreateInstance(typeStartup, false);
            startup.ConfigureServices(Services);
            startup.ConfigureMiddlewares(this);
            HyperaiApplication app = new HyperaiApplication() { Provider = Services.BuildServiceProvider(), Middlewares = middlewares.AsReadOnly() };
            return app;
        }

        public void Use(Type middleware)
        {
            if (!typeof(IMiddleware).IsAssignableFrom(middleware))
            {
                throw new ArgumentException("Type should implements IMiddleware interface.");
            }
            middlewares.Add(middleware);
        }
    }
}
