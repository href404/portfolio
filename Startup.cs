using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Portfolio.Providers;
using Portfolio.Providers.Implementations;

namespace Portfolio
{
    public class Startup
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddSingleton<ISkillProvider, SkillProvider>();
            services.AddSingleton<IAchievementProvider, AchievementProvider>();
        }

        public static void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseForwardedHeaders(GetForwardedHeadersOptions());

            if (env.IsDevelopment()) app.UseDeveloperExceptionPage();
            else ConfigureExceptionHandler(app);

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthorization();
            app.UseEndpoints(GetEndpoints);
        }
        
        private static ForwardedHeadersOptions GetForwardedHeadersOptions()
        {
            return new ForwardedHeadersOptions
            {
                ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto
            };
        }

        private static void ConfigureExceptionHandler(IApplicationBuilder app)
        {
            app.UseExceptionHandler("/Home/Error");
            app.UseHsts();
        }
        
        private static void GetEndpoints(IEndpointRouteBuilder endpoints)
        {
            endpoints.MapControllerRoute("default","{controller=Home}/{action=Index}/{id?}");
        }
    }
}
