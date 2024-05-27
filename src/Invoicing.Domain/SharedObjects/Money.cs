
namespace Invoicing.Domain.SharedObjects;

public class Money : ValueObject
{
    public string Currency { get; private set; }
    public double Amount { get; private set; }
    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Amount;
        yield return Currency;
    }
    private Money(string currency, double amount)
    {
        Currency = currency;
        Amount = amount;
    }

    public static Money Create(string currency, double amount) => new Money(currency, amount);

}