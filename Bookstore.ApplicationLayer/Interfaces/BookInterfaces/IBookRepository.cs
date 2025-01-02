using Bookstore.DomainLayer.Models;

namespace Bookstore.ApplicationLayer.Interfaces.BookInterfaces;

public interface IBookRepository
{
    Task<List<Book>> GetBookList();
    Task<Book> GetBookById(Guid id);
    Task CreateBook(Book book);
    Task UpdateBook(Book book);
    Task DeleteBook(Guid id);
}
