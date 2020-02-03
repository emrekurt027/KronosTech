using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.Localization;

namespace test1
{
    public class Startup
    {

        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });
          
            services.AddLocalization(opts =>
            {
                opts.ResourcesPath = "Resources";
            });

            services.Configure<RequestLocalizationOptions>(opts =>
            {
                var supportedCultures = new List<CultureInfo>
                {
                    new CultureInfo("en-US"),
                    new CultureInfo("tr-TR")
                };
                opts.DefaultRequestCulture = new RequestCulture("tr-TR","tr-TR");
                opts.SupportedCultures = supportedCultures;
                opts.SupportedUICultures = supportedCultures;
            });
           
            services
                .AddMvc()
                .AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix)
                .AddDataAnnotationsLocalization();  
        }
    

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }


            app.UseRequestLocalization(app.ApplicationServices.GetService<IOptions<RequestLocalizationOptions>>().Value);
            
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                name: "default",
                template:"{controller=Home}/{action=Index}/{id?}");

                routes.MapRoute(
                      name: "pEN",
                      template: "{Products}",
                      defaults: new { controller = "Home", action = "Product", culture = "en" });
                routes.MapRoute(
                     name: "pTR",
                     template: "{Urunler}",
                     defaults: new { controller = "Home", action = "Product", culture = "tr" });    
            });

            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseStatusCodePages();
        }       

    }
}
