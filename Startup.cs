using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Portfolio.Providers;
using Portfolio.Providers.Implementations;

namespace Portfolio
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddHttpClient();
            services.AddSingleton<ISkillProvider, SkillProvider>();
            services.AddSingleton<IAchievementProvider, AchievementProvider>();
            //if (Environment.IsDevelopment()) services.AddSingleton<ILogRepository, LogFileRepository>();
            //else services.AddSingleton<ILogRepository, LogHttpRepository>();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            //if (env.IsDevelopment()) app.UseDeveloperExceptionPage();
            //else app.UseExceptionHandler("/Home/Error");

            app.UseStaticFiles();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "defaultRoute",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
