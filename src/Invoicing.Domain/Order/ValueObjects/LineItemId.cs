
namespace Invoicing.Domain.Order.ValueObjects;
public class LineItemId : ValueObject
{
    private LineItemId(Guid id)
    {
        Value = id;
    }

    public Guid Value {get; private set;}
    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public static LineItemId Create(Guid id) => new LineItemId(id);


}