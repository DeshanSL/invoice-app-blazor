
namespace Invoicing.Domain.Customer.ValueObjects;

public class Address : ValueObject
{
    public string Line1 {get; private set;}
    public string Line2 {get; private set;}
    public string Postal {get; private set;}
    public string Country {get; private set;}
    public Address(string line1, string line2, string postal, string country)
    {
        Line1 = line1;
        Line2 = line2;
        Postal = postal;
        Country = country;
    }
    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Line1;
        yield return Line2;
        yield return Country;
        yield return Postal;
    }

    public static Address Create(string line1, string line2, string postal, string country) => new Address(line1, line2, postal, country);
}