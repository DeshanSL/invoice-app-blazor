using Invoicing.Domain.Customer.Entities;
using Invoicing.Domain.Customer.ValueObjects;

namespace Invoicing.Domain.Customer;


public class Customer : AggregateRoot<CustomerId>
{
    public Customer(CustomerId id, string name, Address address) : base(id)
    {
        Name = name;
        Address = address;
    }

    public string Name { get; private set; }
   public Address Address { get; private set; }
    public ContactPerson ContactPerson {get; private set;}

    
}
