using System;
using System.Collections;
using System.Collections.Generic;
using Hyperai.Middlewares;

namespace Hyperai
{
    public class HyperaiServerOptions
    {
        public IReadOnlyList<Type> Middlewares { get; set; }
    }
}
