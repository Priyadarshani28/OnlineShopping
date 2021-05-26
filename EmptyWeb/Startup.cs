using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace EmptyWeb
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
             
              // Configure is responsible for setting HTTP Pipeline
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                //Mapping URL with HTTP Callback Handler
                // Context: Represents HTTP Context handling processing
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("<h1>Hello World!</h1>");
                });
                 endpoints.MapGet("/Aboutus", async context =>
                {
                    await context.Response.WriteAsync("<h1>Transflower Learning Pvt. Ltd.</h1>");
                });
                endpoints.MapGet("/ShoppingCart", async context =>
                {
                    await context.Response.WriteAsync("<h1>My Shopping Cart</h1>");
                });
                endpoints.MapGet("/Orders", async context =>
                {
                    await context.Response.WriteAsync("<h1>Orders Summary</h1>");
                });
                 endpoints.MapGet("/Products", async context =>
                {
                    await context.Response.WriteAsync("<h1>Products Details</h1>");
                });
                endpoints.MapGet("/Login", async context =>
                {
                    await context.Response.WriteAsync("<h1>Validatae User</h1>");
                });
            });
        }
    }
}
