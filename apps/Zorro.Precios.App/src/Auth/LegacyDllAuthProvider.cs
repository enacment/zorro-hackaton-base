using System.Reflection;

namespace Zorro.Precios.App.Auth;

/// <summary>
/// Adapter de autenticación legacy vía DLL externa.
/// No versiona binarios en repo; carga rutas locales configuradas.
/// </summary>
public sealed class LegacyDllAuthProvider : IAuthProvider
{
    private readonly string _za98OutPath;
    private readonly string _zaio2206Path;
    private readonly string _iniPath;
    private AuthSession? _session;

    public LegacyDllAuthProvider(string za98OutPath, string zaio2206Path, string iniPath)
    {
        _za98OutPath = za98OutPath;
        _zaio2206Path = zaio2206Path;
        _iniPath = iniPath;
    }

    public Task<AuthResult> LoginAsync(string username, string password, CancellationToken ct = default)
    {
        try
        {
            if (!File.Exists(_za98OutPath) || !File.Exists(_zaio2206Path) || !File.Exists(_iniPath))
                return Task.FromResult(new AuthResult(false, "DLL/INI legacy no encontrados en rutas locales.", null));

            // Carga dinámica para evitar acoplar el repo a binarios propietarios.
            var za98Assembly = Assembly.LoadFrom(_za98OutPath);
            var zaioAssembly = Assembly.LoadFrom(_zaio2206Path);

            // TODO: mapear método real de autenticación cuando se confirme contrato técnico.
            // Por ahora validamos disponibilidad de binarios y dejamos gancho de integración.
            var hasTypes = za98Assembly.GetTypes().Length > 0 && zaioAssembly.GetTypes().Length > 0;
            if (!hasTypes)
                return Task.FromResult(new AuthResult(false, "No se pudieron cargar tipos de DLL legacy.", null));

            // Placeholder temporal: sesión mockeada una vez que DLL están listas.
            _session = new AuthSession(
                UserId: "legacy-user",
                Username: username,
                AccessToken: "legacy-token-pending-real-auth",
                ExpiresAtUtc: DateTimeOffset.UtcNow.AddHours(8)
            );

            return Task.FromResult(new AuthResult(true, null, _session));
        }
        catch (Exception ex)
        {
            return Task.FromResult(new AuthResult(false, $"Error en adapter DLL: {ex.Message}", null));
        }
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
