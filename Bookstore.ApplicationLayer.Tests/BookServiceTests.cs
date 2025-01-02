using Bookstore.ApplicationLayer.Interfaces.BookInterfaces;
using Bookstore.ApplicationLayer.Services.BookServices;
using Bookstore.DomainLayer.Models;
using Moq;
using Xunit;

namespace Bookstore.ApplicationLayer.Tests;

public class BookServiceTests
{
    private readonly Mock<IBookRepository> _mockRepository;
    private readonly BookService _service;

    public BookServiceTests()
    {
        _mockRepository = new Mock<IBookRepository>();
        _service = new BookService(_mockRepository.Object);
    }

    [Fact]
    public async Task GetBookListAsync_ReturnBooks()
    {
        var expectedBooks = new List<Book>
        {
            new Book { BookId = Guid.Parse("56DBA618-24BB-42A9-B316-2B8EB15D6989"), ISBN = "1111112222223", Title = "Book #1", Description = "Description #1", AuthorName = "Author #1", PagesNumber = 100, Quantity = 10},
            new Book { BookId = Guid.Parse("92C025E2-F036-43BB-97B4-E3A2924E2470"), ISBN = "1111112222224", Title = "Book #2", Description = "Description #2", AuthorName = "Author #2", PagesNumber = 200, Quantity = 20},
        };

        _mockRepository.Setup(x => x.GetBookList()).ReturnsAsync(expectedBooks);

        var result = await _service.GetBookList();

        Assert.NotNull(result);
        Assert.Equal(2, result.Count());
        Assert.Equal(expectedBooks, result);
    }

    [Fact]
    public async Task GetBookByIdAsync_ReturnBook()
    {
        var bookId = Guid.Parse("56DBA618-24BB-42A9-B316-2B8EB15D6989");
        var expectedBook = new Book { BookId = bookId, ISBN = "1111112222223", Title = "Book #1", Description = "Description #1", AuthorName = "Author #1", PagesNumber = 100, Quantity = 10 };

        _mockRepository.Setup(x => x.GetBookById(bookId)).ReturnsAsync(expectedBook);

        var result = await _service.GetBookById(bookId);

        Assert.NotNull(result);
        Assert.Equal(expectedBook, result);
    }

    [Fact]
    public async Task AddBookAsync_RepositoryMethodCall()
    {
        var book = new Book { BookId = Guid.Parse("56DBA618-24BB-42A9-B316-2B8EB15D6989"), ISBN = "1111112222223", Title = "Book #1", Description = "Description #1", AuthorName = "Author #1", PagesNumber = 100, Quantity = 10 };

        await _service.CreateBook(book);

        _mockRepository.Verify(x => x.CreateBook(book), Times.Once);
    }

    [Fact]
    public async Task UpdateBookAsync_RepositoryMethodCall()
    {
        var book = new Book { BookId = Guid.Parse("56DBA618-24BB-42A9-B316-2B8EB15D6989"), ISBN = "1111112222223", Title = "Book_Update #1", Description = "Description_Update #1", AuthorName = "Author #1", PagesNumber = 100, Quantity = 10 };

        await _service.UpdateBook(book);

        _mockRepository.Verify(x => x.UpdateBook(book), Times.Once);
    }

    [Fact]
    public async Task DeleteBookAsync_RepositoryMethodCall()
    {
        var bookId = Guid.Parse("56DBA618-24BB-42A9-B316-2B8EB15D6989");

        await _service.DeleteBook(bookId);

        _mockRepository.Verify(x => x.DeleteBook(bookId), Times.Once);
    }

}
