using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Portfolio.Providers;
using Portfolio.Providers.Implementations;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddSingleton<ISkillProvider, SkillProvider>();
builder.Services.AddSingleton<IAchievementProvider, AchievementProvider>();
builder.Services.AddSingleton<IExperienceProvider, ExperienceProvider>();

var app = builder.Build();

app.UseForwardedHeaders(new ForwardedHeadersOptions
{
    ForwardedHeaders = 
        ForwardedHeaders.XForwardedFor | 
        ForwardedHeaders.XForwardedProto
});

if (!app.Environment.IsDevelopment()) 
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.UseEndpoints((endpoints) => 
    endpoints.MapControllerRoute(
            "default",
            "{controller=Home}/{action=Index}/{id?}"));

app.Run();