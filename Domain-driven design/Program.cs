
using Domain_driven_design;

var user = User.Create("user@mail.com", "First Name", "Last Name");

foreach (IDomainEvent domainEvent in user.DomainEvents)
{
    if (domainEvent is UserRegisteredDomainEvent u)
    {
        Console.WriteLine($"User Registered eventId={u.Id}, Time={u.OccurredOnUtc}");
    }
}
