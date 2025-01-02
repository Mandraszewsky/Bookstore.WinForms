using Bookstore.ApplicationLayer.Interfaces.BookInterfaces;
using Bookstore.DomainLayer.Models;

namespace Bookstore.ApplicationLayer.Services.BookServices;

public class BookService : IBookService
{
    private readonly IBookRepository _bookRepository;

    public BookService(IBookRepository bookRepository)
    {
        _bookRepository = bookRepository;
    }

    public async Task CreateBook(Book book)
    {
        await _bookRepository.CreateBook(book);
    }

    public async Task UpdateBook(Book book)
    {
        await _bookRepository.UpdateBook(book);
    }

    public async Task DeleteBook(Guid id)
    {
        await _bookRepository.DeleteBook(id);
    }

    public async Task<Book> GetBookById(Guid id)
    {
        return await _bookRepository.GetBookById(id);
    }

    public async Task<List<Book>> GetBookList()
    {
        return await _bookRepository.GetBookList();
    }
}
