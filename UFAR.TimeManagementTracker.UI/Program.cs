using Microsoft.EntityFrameworkCore;
using UFAR.TimeManagementTracker.Backend.Data;
using UFAR.TimeManagementTracker.UI.Components;
using UFAR.TimeManagementTracker.Backend.Services;
using BlazorLocalizer;
using Microsoft.Extensions.DependencyInjection;

namespace UFAR.TimeManagementTracker.UI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);  //appsetting.json 

            // Add services to the container.
            builder.Services.AddRazorComponents()
                .AddInteractiveServerComponents();

            builder.Services.AddDbContext<TimeManagementContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
            );

            builder.Services.AddScoped<ITimeManagementService, TimeManagementService>();

            builder.Services.AddLocalization(options => options.ResourcesPath = "Resources");

            var supportedCultures = new[] { "en", "fr", "es", "de" };
            var localizationOptions = new RequestLocalizationOptions()
                .SetDefaultCulture(supportedCultures[0])
                .AddSupportedCultures(supportedCultures)
                .AddSupportedUICultures(supportedCultures);

            builder.Services.AddHttpClient("API", client =>
            {
                client.BaseAddress = new Uri("https://ufartimemanagement.azurewebsites.net/");
            });

            // Add CORS policy to allow requests from the Blazor UI (running on localhost:7139)
            builder.Services.AddCors(options =>
            {
                options.AddPolicy("AllowBlazorUI",
                    builder => builder.WithOrigins("http://localhost:7139")
                                      .AllowAnyHeader()
                                      .AllowAnyMethod());
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline

            // Enable CORS for the Blazor UI
            app.UseCors("AllowBlazorUI");

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseAntiforgery();

            // Use localization
            app.UseRequestLocalization(localizationOptions);

            // Map the Razor components for server-side rendering
            app.MapRazorComponents<App>()
                .AddInteractiveServerRenderMode();

            app.Run();
        }
    }
}
