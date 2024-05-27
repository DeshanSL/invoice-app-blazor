namespace Invoicing.Domain;

public abstract class Error
{
    protected Error(string message, string? description = null)
    {
        Message = message;
        Description = description;
    }
    public string Message { get; set; }
    public string? Description { get; private set; } = null;
}