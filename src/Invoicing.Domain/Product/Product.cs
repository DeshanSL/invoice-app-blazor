using Invoicing.Domain.Product.ValueObjects;
using Invoicing.Domain.SharedObjects;

namespace Invoicing.Domain.Product;

public class Product : AggregateRoot<ProductId>
{
    public string Name { get; private set; }
    public Sku Sku { get; private set; }
    public Size Size { get; private set; }
    public int ItemsPerContainer { get; private set; }
    public Money Price { get; private set; }
    private Product(ProductId productId, string name, Sku sku, Size size, int itemsPerContainer, Money price) : base(productId)
    {
        Name = name;
        Sku = sku;
        Size = size;
        Price = price;
        ItemsPerContainer = itemsPerContainer;
    }

    public static Result<Product, ProductError> Create(string name, Sku sku, Size size, int itemsPerContainer, Money price)
    {
        if (itemsPerContainer < 1)
        {
            return ProductError.ItemsPerContainerCannotBeLessThanOne;
        }

        return new Product(ProductId.Create(Guid.NewGuid()), name, sku, size, itemsPerContainer, price);
    }

    public void test(){
        Result<Product, ProductError> result = Product.Create("Dunar", Sku.Create("12321"), Size.Create(12, Size.WeightUnit.Kg), 2, Money.Create("LKR", 12));

        var obj = result.Value;
    }
}