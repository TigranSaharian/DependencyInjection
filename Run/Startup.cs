using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace Run
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app)
        {
            int x = 5;
            int y = 6;
            int z = 3;
            app.Use(async (contexr, next) =>
            {
                z = x * y;
                await next.Invoke();

                z = z * 5;
                await contexr.Response.WriteAsync($"result: {z}");
            });

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync($"x * y = {z}\n");
            });
        }
    }
}
