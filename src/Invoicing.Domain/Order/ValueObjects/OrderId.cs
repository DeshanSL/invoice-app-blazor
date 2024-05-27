
namespace Invoicing.Domain.Order.ValueObjects;
public class OrderId : ValueObject
{
    public Guid Value { get; private set; }
    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
    public static OrderId Create(Guid id) => new OrderId(id);
    public OrderId(Guid id)
    {
        Value = id;
    }
}