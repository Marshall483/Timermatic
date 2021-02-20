using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyConole
{
    public class Startup
    {

        public void ConfigurationSrevices(IServiceCollection services)
        {

        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            app.UseRouting();

            app.UseEndpoints(ep =>
            {
                ep.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello Timerchan!");
                });
            });

        }
    }
}
