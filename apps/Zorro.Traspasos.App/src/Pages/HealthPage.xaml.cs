using Zorro.Traspasos.App.Health;

namespace Zorro.Traspasos.App.Pages;

public partial class HealthPage : ContentPage
{
    private readonly IHealthCheckService _healthCheckService;

    public HealthPage(IHealthCheckService healthCheckService)
    {
        InitializeComponent();
        _healthCheckService = healthCheckService;
    }

    private async void OnVerifyClicked(object sender, EventArgs e)
    {
        var result = await _healthCheckService.CheckAsync();
        AppStatusLabel.Text = result.AppOk ? "✅ OK" : "❌ Error";
        ApiStatusLabel.Text = result.ApiOk ? "✅ OK" : $"❌ {result.Error}";
        EndpointLabel.Text = $"Endpoint: {result.ApiEndpoint}";
        CheckTimeLabel.Text = $"Última verificación: {result.CheckedAtUtc.ToLocalTime():HH:mm:ss}";
    }
}
