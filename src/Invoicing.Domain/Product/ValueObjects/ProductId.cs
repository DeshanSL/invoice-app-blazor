
namespace Invoicing.Domain.Product.ValueObjects;
public class ProductId : ValueObject
{
    public Guid Value { get; private set; }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
    private ProductId(Guid id)
    {
        Value = id;
    }

    public static ProductId Create(Guid id) => new ProductId(id);
}