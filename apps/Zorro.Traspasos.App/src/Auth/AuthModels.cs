namespace Zorro.Traspasos.App.Auth;

public sealed record AuthSession(
    string UserId,
    string Username,
    string AccessToken,
    DateTimeOffset ExpiresAtUtc
);

public sealed record AuthResult(
    bool Success,
    string? Error,
    AuthSession? Session
);
