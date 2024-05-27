
namespace Invoicing.Domain.Customer.ValueObjects;
public class ContactPersonId : ValueObject
{
    public Guid Id { get; private set; }
    public ContactPersonId(Guid id)
    {
        Id = id;
    }
    public static ContactPersonId Create(Guid id) => new (id);
    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Id;
    }
}