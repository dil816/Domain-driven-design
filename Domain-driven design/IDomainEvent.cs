namespace Domain_driven_design;

internal interface IDomainEvent
{
    Guid Id { get; }
    DateTime OccurredOnUtc { get; }
}

