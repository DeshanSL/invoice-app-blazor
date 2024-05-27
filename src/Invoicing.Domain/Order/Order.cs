using Invoicing.Domain.Order.Entities;
using Invoicing.Domain.Order.ValueObjects;

namespace Invoicing.Domain.Order;
public class Order : AggregateRoot<OrderId>
{
    private readonly HashSet<LineItem> _lineItems = new();

    public CustomerId CustomerId { get; private set; }
    public DateTime CreatedDate { get; private set; }

    private Order(OrderId orderId, CustomerId customerId, DateTime createdDateTime) : base(orderId)
    {
        CustomerId = customerId;
        CreatedDate = createdDateTime;
    }

    public static Order Create( CustomerId customerId) => new Order(OrderId.Create(Guid.NewGuid()), customerId, DateTime.Now);
    public void AddLineItem(Product.Product product, double qty)
    {
        var lineItem = LineItem.Create(product.Id, Id, product.Price, qty);
        _lineItems.Add(lineItem);
    }

}