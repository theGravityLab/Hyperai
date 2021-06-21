using Hyperai.Middlewares;

namespace Hyperai
{
    public static class HyperaiApplicationBuilderExtensions
    {
        public static IHyperaiApplicationBuilder Use<TM>(this IHyperaiApplicationBuilder builder) where TM : IMiddleware
        {
            builder.Use(typeof(TM));
            return builder;
        }
    }
}
