namespace Zorro.Planogramas.App.Auth;

public sealed class MockAuthProvider : IAuthProvider
{
    private AuthSession? _session;

    public Task<AuthResult> LoginAsync(string username, string password, CancellationToken ct = default)
    {
        if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            return Task.FromResult(new AuthResult(false, "Usuario o contraseña vacíos.", null));

        _session = new AuthSession(
            UserId: "mock-user",
            Username: username,
            AccessToken: "mock-token",
            ExpiresAtUtc: DateTimeOffset.UtcNow.AddHours(8)
        );

        return Task.FromResult(new AuthResult(true, null, _session));
    }

    public Task LogoutAsync(CancellationToken ct = default)
    {
        _session = null;
        return Task.CompletedTask;
    }

    public Task<AuthSession?> GetCurrentSessionAsync(CancellationToken ct = default)
        => Task.FromResult(_session);

    public Task<bool> IsAuthenticatedAsync(CancellationToken ct = default)
        => Task.FromResult(_session is not null && _session.ExpiresAtUtc > DateTimeOffset.UtcNow);
}
