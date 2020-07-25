namespace Hyperai
{
    public static class HyperaiApplicationExtensions
    {
        public static IHyperaiApplication Run(this IHyperaiApplication app)
        {
            app.StartAsync().Wait();
            return app;
        }
    }
}