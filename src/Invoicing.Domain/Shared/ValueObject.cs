namespace Invoicing.Domain;

public abstract class ValueObject : IEquatable<ValueObject>
{
    public abstract IEnumerable<object> GetEqualityComponents();

    public override bool Equals(object? obj)
    {
        if (obj == null || obj.GetType() != GetType())
        {
            return false;
        }
        var valueObject = (ValueObject)obj;

        return GetEqualityComponents().SequenceEqual(valueObject.GetEqualityComponents());
    }

    public static bool operator ==(ValueObject right, ValueObject left)
    {
        return Equals(right, left);
    }
    public static bool operator !=(ValueObject right, ValueObject left)
    {
        return !Equals(right, left);
    }

    public override int GetHashCode()
    {
        return GetEqualityComponents().Select(a => a?.GetHashCode() ?? 0)
            .Aggregate((x, y) => x ^ y);
    }

    public bool Equals(ValueObject? other)
    {
        return Equals((object?)other);
    }
    public ValueObject()
    {

    }
}
