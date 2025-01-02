namespace Bookstore.DomainLayer.Models;

public class Author
{
    public Guid? AuthorId { get; set; }
    public string? AuthorName { get; set; } = default!;
}
