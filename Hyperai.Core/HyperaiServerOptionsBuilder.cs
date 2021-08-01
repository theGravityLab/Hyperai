using System;
using System.Collections.Generic;
using Hyperai.Middlewares;

namespace Hyperai
{
    public class HyperaiServerOptionsBuilder: IBuilder<HyperaiServerOptions>
    {
        private readonly List<Type> middlewares = new List<Type>();

        public HyperaiServerOptionsBuilder Use(Type middleware)
        {
            if (!typeof(IMiddleware).IsAssignableFrom(middleware))
                throw new ArgumentException("Type should implements IMiddleware interface.");
            middlewares.Add(middleware);
            return this;
        }
        public HyperaiServerOptions Build()
        {
            return new()
            {
                Middlewares = middlewares.AsReadOnly()
            };
        }
    }
}
