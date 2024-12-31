namespace Bookstore.Domain.Models;

public class Customer
{
    public Guid? CustomerID { get; set; }
    public string? CustomerName { get; set; } = default!;
    public string? EmailAddress { get; set; } = default!;
}
