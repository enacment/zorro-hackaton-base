namespace Zorro.Application.Common;

/// <summary>
/// Application.Common — shared application-layer abstractions across all Zorro apps.
///
/// Place here:
/// - CQRS interfaces (ICommand, IQuery, ICommandHandler, IQueryHandler)
/// - Common use-case base classes
/// - Shared DTOs and mapping interfaces
/// - Validation helpers (IValidator, ValidationResult)
/// - Common application exceptions (NotFoundException, ValidationException)
/// - Cross-cutting concerns: pagination, sorting, filtering contracts
///
/// Depends on Domain.Common. Does NOT depend on Infrastructure.
/// </summary>
public static class ApplicationCommonModule
{
    // Registration hook — call from MauiProgram.cs or host builder if needed.
    public static void Register() { }
}
