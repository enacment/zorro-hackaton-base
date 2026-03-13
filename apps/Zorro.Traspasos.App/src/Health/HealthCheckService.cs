namespace Zorro.Traspasos.App.Health;

public sealed class HealthCheckService : IHealthCheckService
{
    private readonly HttpClient _httpClient;
    private readonly string _endpoint;

    public HealthCheckService(HttpClient httpClient, string endpoint)
    {
        _httpClient = httpClient;
        _endpoint = endpoint;
    }

    public async Task<HealthCheckResult> CheckAsync(CancellationToken ct = default)
    {
        try
        {
            using var response = await _httpClient.GetAsync(_endpoint, ct);
            return new HealthCheckResult(
                AppOk: true,
                ApiOk: response.IsSuccessStatusCode,
                ApiEndpoint: _endpoint,
                Error: response.IsSuccessStatusCode ? null : $"HTTP {(int)response.StatusCode}",
                CheckedAtUtc: DateTimeOffset.UtcNow
            );
        }
        catch (Exception ex)
        {
            return new HealthCheckResult(
                AppOk: true,
                ApiOk: false,
                ApiEndpoint: _endpoint,
                Error: ex.Message,
                CheckedAtUtc: DateTimeOffset.UtcNow
            );
        }
    }
}
