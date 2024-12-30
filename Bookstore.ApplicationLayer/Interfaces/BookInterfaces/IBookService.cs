using Bookstore.Domain.Models;

namespace Bookstore.ApplicationLayer.Interfaces.BookInterfaces;

public interface IBookService
{
    List<Book> GetBooksAsync();
    Task<Book> GetBookById(Guid id);
    Task CreateBook(Book book);
    Task UpdateBook(Book book);
    Task DeleteBook(Guid id);
}

