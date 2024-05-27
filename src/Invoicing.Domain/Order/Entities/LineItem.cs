using Invoicing.Domain.Order.ValueObjects;
using Invoicing.Domain.Product.ValueObjects;
using Invoicing.Domain.SharedObjects;

namespace Invoicing.Domain.Order.Entities;
public class LineItem : Entity<LineItemId>
{
    public ProductId ProductId { get; private set; }
    public OrderId OrderId { get; private set; }
    public double Qty { get; private set; }
    public Money Price { get; private set; }
    public string? Description { get; private set; }
    private LineItem(LineItemId lineItemId, ProductId productId, OrderId orderId, Money currentPrice, double qty)
    : base(lineItemId)
    {
        ProductId = productId;
        Price = currentPrice;
        Qty = qty;
        OrderId = orderId;
    }

    public static LineItem Create(ProductId productId, OrderId orderId, Money currentPrice, double qty) =>
    new LineItem(LineItemId.Create(Guid.NewGuid()), productId, orderId, currentPrice, qty);
}
