namespace Zorro.Traspasos.App.Auth;

public interface IAuthProvider
{
    Task<AuthResult> LoginAsync(string username, string password, CancellationToken ct = default);
    Task LogoutAsync(CancellationToken ct = default);
    Task<AuthSession?> GetCurrentSessionAsync(CancellationToken ct = default);
    Task<bool> IsAuthenticatedAsync(CancellationToken ct = default);
}
