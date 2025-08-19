﻿namespace Domain_driven_design;

internal abstract class Entity
{
    private readonly List<IDomainEvent> _domainEvents = [];
    protected Entity() { }

    public IReadOnlyCollection<IDomainEvent> DomainEvents => _domainEvents.ToList();

    public void ClearDomainEvents()
    {
        _domainEvents.Clear();
    }

    protected void Raise(IDomainEvent domainEvent)
    {
        _domainEvents.Add(domainEvent);
    }
}
