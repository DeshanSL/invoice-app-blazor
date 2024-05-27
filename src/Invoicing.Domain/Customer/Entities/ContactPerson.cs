using System.Runtime.CompilerServices;
using Invoicing.Domain.Customer.ValueObjects;

namespace Invoicing.Domain.Customer.Entities;

public class ContactPerson : Entity<ContactPersonId>
{
    private readonly HashSet<string> _contactNumbers = new HashSet<string>();

    public ContactPerson(ContactPersonId id, string name) : base(id)
    {
        Name = name;
    }

    public string Name { get; private set; }

    public static ContactPerson Create(string name) => new ContactPerson(ContactPersonId.Create(Guid.NewGuid()), name);
    public void AddContactNumber(string phoneNumber)
    {
        if (phoneNumber.Length != 10)
        {

        }
        _contactNumbers.Add(phoneNumber);
    }
}