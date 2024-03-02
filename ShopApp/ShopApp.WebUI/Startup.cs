using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using ShopApp.data.Abstract;
using ShopApp.data.Concrete.EfCore;
using ShopApp.business.Abstract;
using ShopApp.business.Concrete;

namespace ShopApp.WebUI
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            // mvc
            // razor pages
            services.AddScoped<IProductRepository,EfCoreProductRepository>();
            services.AddScoped<IProductService,ProductManager>(); 
            services.AddControllersWithViews();
        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseStaticFiles(); // wwwroot

            app.UseStaticFiles(new StaticFileOptions
            {
                FileProvider = new PhysicalFileProvider(
                    Path.Combine(Directory.GetCurrentDirectory(),"node_modules")),
                    RequestPath="/modules"                
            });

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
             
            app.UseRouting();

            // localhost:5000
            // localhost:5000/home
            // localhost:5000/home/index
            // localhost:5000/product/details/3
            // localhost:5000/product/list/2
            // localhost:5000/category/list

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern:"{controller=Home}/{action=Index}/{id?}"
                );
            });
        }
    }
}
