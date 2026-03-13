using Microsoft.Extensions.DependencyInjection;
using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Hosting;
using Zorro.Template.App.Auth;
using Zorro.Template.App.Health;
using Zorro.Template.App.Pages;

namespace Zorro.Template.App;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();

        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
            });

        // HttpClient
        builder.Services.AddSingleton<HttpClient>();

        // Auth
        builder.Services.AddSingleton<IAuthProvider, MockAuthProvider>();

        // Health — reads endpoint from appsettings or uses placeholder
        builder.Services.AddSingleton<IHealthCheckService>(sp =>
            new HealthCheckService(
                sp.GetRequiredService<HttpClient>(),
                "https://api.enacment.com/health"
            ));

        // Pages
        builder.Services.AddTransient<LoginPage>();
        builder.Services.AddTransient<DashboardPage>();
        builder.Services.AddTransient<HealthPage>();

        return builder.Build();
    }
}
