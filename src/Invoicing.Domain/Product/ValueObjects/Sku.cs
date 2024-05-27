
namespace Invoicing.Domain.Product.ValueObjects;
public class Sku : ValueObject
{
    public string Value { get; private set; }
    private Sku(string value)
    {
        Value = value;
    }
    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public static Sku Create(string value){
        return new Sku(value);
    }
}