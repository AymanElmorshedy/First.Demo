using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace First.Demo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var WebApplicationBuilder = WebApplication.CreateBuilder();

            #region ConfigureServices
            WebApplicationBuilder.Services.AddControllersWithViews(); 
            #endregion

            var app = WebApplicationBuilder.Build();
            #region Configure
            if (app.Environment.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseRouting();
            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapGet("/", async context =>
            //    {
            //        await context.Response.WriteAsync("Hello World");

            //    });
            //    endpoints.MapGet("/Home", async context =>
            //    {
            //        await context.Response.WriteAsync("Hello From Home Page!");
            //    });
            //    endpoints.MapControllerRoute(
            //        name: "default",
            //        pattern: "{Controller=Home}/{Action=Index}/{id?}"
            //        //defaults: new { controller = "Home", Action = "Index" },
            //        //constraints: new { id = new IntRouteConstraint() }//old And Not Used
            //        );
            app.MapGet("/", async context =>
            {
                await context.Response.WriteAsync("Hello World");

            });
            app.MapGet("/Home", async context =>
            {
                await context.Response.WriteAsync("Hello From Home Page!");
            });
            app.MapControllerRoute(
                name: "default",
                pattern: "{Controller=Home}/{Action=Index}/{id?}"
                //defaults: new { controller = "Home", Action = "Index" },
                //constraints: new { id = new IntRouteConstraint() }//old And Not Used
                );
            #endregion

            app.UseStaticFiles();

            app.Run();

        }

        //public static IHostBuilder CreateHostBuilder(string[] args) =>
        //    Host.CreateDefaultBuilder(args)
        //        .ConfigureWebHostDefaults(webBuilder =>
        //        {
        //            webBuilder.UseStartup<Startup>();
        //        });
    }
}
