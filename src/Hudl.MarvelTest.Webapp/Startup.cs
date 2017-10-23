using Hudl.Marvel.Platform.Startup;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Hudl.SpeedTest.Webapp
{
    public class Startup : IMarvelStartup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // Add framework services.
            services.AddMarvelPlatform(options =>
            {
                options.WarmUp = null;
                options.RequestScopedWarmUp = null;
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app)
        {
            app.UseMarvelPlatform();
        }

        // TODO : account for these remaining startup lines
        // protected override void OnApplicationStart()
        // {
        //     InitializeRabbitMq();
        //     TaskScheduler.UnobservedTaskException += HandleUnobservedTaskException;
        // }
    }
}