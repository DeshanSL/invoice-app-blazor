
namespace Invoicing.Domain.Product.ValueObjects;
public class Size : ValueObject
{
    public WeightUnit Unit { get; set; }
    public double Value { get; set; }
    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Unit;
        yield return Value;
    }

    public enum WeightUnit
    {
        Kg = 1,
        g = 2
    }

    private Size(double value, WeightUnit unit)
    {
        Value = value;
        Unit = unit;
    }
    public static Size Create(double value, WeightUnit unit) => new Size(value, unit);
}