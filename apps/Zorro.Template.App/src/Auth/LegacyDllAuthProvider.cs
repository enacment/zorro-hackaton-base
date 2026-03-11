namespace Zorro.Template.App.Auth;

/// <summary>
/// Placeholder para integrar la DLL de autenticación legacy.
/// Implementación real pendiente a contrato técnico final.
/// </summary>
public sealed class LegacyDllAuthProvider : IAuthProvider
{
    public Task<AuthResult> LoginAsync(string username, string password, CancellationToken ct = default)
        => Task.FromResult(new AuthResult(false, "Integración DLL pendiente.", null));

    public Task LogoutAsync(CancellationToken ct = default)
        => Task.CompletedTask;

    public Task<AuthSession?> GetCurrentSessionAsync(CancellationToken ct = default)
        => Task.FromResult<AuthSession?>(null);

    public Task<bool> IsAuthenticatedAsync(CancellationToken ct = default)
        => Task.FromResult(false);
}
