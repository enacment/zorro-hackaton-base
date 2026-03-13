namespace Zorro.Domain.Common;

/// <summary>
/// Domain.Common — shared domain primitives across all Zorro apps.
///
/// Place here:
/// - Base entity/aggregate root classes (Entity<TId>, AggregateRoot<TId>)
/// - Domain events (IDomainEvent)
/// - Value objects (ValueObject base)
/// - Common domain exceptions (DomainException)
/// - Shared enums and constants used in domain logic
///
/// Do NOT put infrastructure concerns (EF, HTTP, DI) here.
/// </summary>
public static class DomainCommonModule
{
    // Registration hook — call from MauiProgram.cs or host builder if needed.
    public static void Register() { }
}
