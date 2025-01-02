using Bookstore.ApplicationLayer.Interfaces.AuthorInterfaces;
using Bookstore.ApplicationLayer.Services.AuthorServices;
using Bookstore.DomainLayer.Models;
using Moq;
using Xunit;

namespace Bookstore.ApplicationLayer.Tests;

public class AuthorServiceTests
{
    private readonly Mock<IAuthorRepository> _mockRepository;
    private readonly AuthorService _service;

    public AuthorServiceTests()
    {
        _mockRepository = new Mock<IAuthorRepository>();
        _service = new AuthorService(_mockRepository.Object);
    }

    [Fact]
    public async Task GetAuthorListAsync_ReturnAuthors()
    {
        var expectedAuthors = new List<Author>
        {
            new Author { AuthorId = Guid.Parse("F77943D5-772F-4DFD-80C5-F4BE4DBEC683"), AuthorName = "Author #1" },
            new Author { AuthorId = Guid.Parse("F0870AC0-5120-4A23-BC54-3442837AA671"), AuthorName = "Author #2" },
        };

        _mockRepository.Setup(x => x.GetAuthorList()).ReturnsAsync(expectedAuthors);

        var result = await _service.GetAuthorList();

        Assert.NotNull(result);
        Assert.Equal(2, result.Count());
        Assert.Equal(expectedAuthors, result);
    }
}
