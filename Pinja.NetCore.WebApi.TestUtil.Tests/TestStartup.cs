using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using NSubstitute;
using Pinja.NetCore.WebApi.TestUtil.Tests.Dummy;

namespace Pinja.NetCore.WebApi.TestUtil.Tests
{
    public class TestStartup
    {
        public TestStartup()
        {
        }

        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllers()
                .AddJsonOptions(options =>
                {
                    options.JsonSerializerOptions.Converters.Add(new CustomTestObjectConverter());
                });
                

            services.AddSingleton(Substitute.For<IExternalDepency>());
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseRouting();
            app.UseEndpoints(endpoints => {
                endpoints.MapControllers();
            });
        }
    }
}
