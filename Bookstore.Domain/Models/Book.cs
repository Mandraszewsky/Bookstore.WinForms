﻿namespace Bookstore.Domain.Models;

public class Book
{
    public Guid? BookId { get; set; }
    public string? ISBN { get; set; } = default!;
    public string? Title { get; set; } = default!;
    public string? Description { get; set; } = default!;
    public string? Author { get; set; } = default!;
    public int? PagesNumber { get; set; } = default!;
    public int? Quantity { get; set; } = default!;
    public DateTime? PublicationDate { get; set; } = default!;
}
