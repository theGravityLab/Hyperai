using Microsoft.Extensions.DependencyInjection;

namespace Hyperai
{
    public interface IHyperaiApplicationBuilderStartup
    {
        void ConfigureServices(IServiceCollection services);

        void ConfigureMiddlewares(IHyperaiApplicationBuilder app);
    }
}