
using Domain_driven_design;

var user = User.Create("user@mail.com", "First Name", "Last Name");

user.Update("Updated First Name", "Updated Last Name");

foreach (IDomainEvent domainEvent in user.DomainEvents)
{
    IEnumerable<string> props = domainEvent.GetType().GetProperties()
        .Select(p => $"{p.Name}={p.GetValue(domainEvent)}");

    Console.WriteLine($"{domainEvent.GetType().Name}: {string.Join(", ", props)}\n");

    //if (domainEvent is UserRegisteredDomainEvent u)
    //{
    //    Console.WriteLine($"User Registered eventId={u.Id}, Time={u.OccurredOnUtc}");
    //}

    //if (domainEvent is UserProfileUpdatedDomainEvent p)
    //{
    //    Console.WriteLine($"User Profile Update eventId={p.Id}, Time={p.OccurredOnUtc}");
    //}
}
