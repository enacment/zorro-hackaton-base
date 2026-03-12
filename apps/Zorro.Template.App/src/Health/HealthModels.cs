namespace Zorro.Template.App.Health;

public sealed record HealthCheckResult(
    bool AppOk,
    bool ApiOk,
    string ApiEndpoint,
    string? Error,
    DateTimeOffset CheckedAtUtc
);
