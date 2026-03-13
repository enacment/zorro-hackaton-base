namespace Zorro.Infrastructure.Common;

/// <summary>
/// Infrastructure.Common — shared infrastructure helpers across all Zorro apps.
///
/// Place here:
/// - HTTP client base classes and helpers
/// - Secure storage helpers (ISecureStore)
/// - Connectivity wrappers
/// - Shared serialization settings (System.Text.Json options)
/// - Base repository interfaces and implementations
/// - Logging extensions
/// - Shared DI extension methods for infrastructure services
///
/// Depends on Domain.Common and Application.Common.
/// </summary>
public static class InfrastructureCommonModule
{
    // Registration hook — call from MauiProgram.cs or host builder if needed.
    public static void Register() { }
}
