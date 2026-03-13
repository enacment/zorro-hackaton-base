namespace Zorro.Planogramas.App.Health;

public interface IHealthCheckService
{
    Task<HealthCheckResult> CheckAsync(CancellationToken ct = default);
}
