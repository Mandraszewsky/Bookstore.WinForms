using Bookstore.Domain.Models;

namespace Bookstore.Application.Interfaces.BookInterfaces;

public interface IBookService
{
    List<Book> GetBooksAsync();
}
