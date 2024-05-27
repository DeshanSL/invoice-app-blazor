
namespace Invoicing.Domain;

public class CustomerId : ValueObject
{
    public Guid Value {get; private set;}

    public CustomerId(Guid id)
    {
        Value = id;
    }
    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}