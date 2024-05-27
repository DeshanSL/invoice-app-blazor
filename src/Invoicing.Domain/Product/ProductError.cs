namespace Invoicing.Domain.Product;

public class ProductError : Error
{
    public ProductError(string message, string? description = null) : base(message, description)
    {
    }

    public static ProductError ItemsPerContainerCannotBeLessThanOne => new ProductError("Items per container can not be less than one item.");
}