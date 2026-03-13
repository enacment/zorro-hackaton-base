using Microsoft.Extensions.DependencyInjection;
using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Hosting;
using Zorro.Traspasos.App.Auth;
using Zorro.Traspasos.App.Health;
using Zorro.Traspasos.App.Pages;

namespace Zorro.Traspasos.App;

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

        builder.Services.AddSingleton<HttpClient>();
        builder.Services.AddSingleton<IAuthProvider, MockAuthProvider>();
        builder.Services.AddSingleton<IHealthCheckService>(sp =>
            new HealthCheckService(
                sp.GetRequiredService<HttpClient>(),
                "https://api.enacment.com/health"
            ));

        builder.Services.AddTransient<LoginPage>();
        builder.Services.AddTransient<TraspasoPage>();
        builder.Services.AddTransient<HealthPage>();

        return builder.Build();
    }
}
