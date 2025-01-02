using Bookstore.ApplicationLayer.Interfaces.CustomerInterfaces;
using Bookstore.ApplicationLayer.Services.CustomerServices;
using Bookstore.DomainLayer.Models;
using Moq;
using Xunit;

namespace Bookstore.ApplicationLayer.Tests;

public class CustomerServiceTests
{
    private readonly Mock<ICustomerRepository> _mockRepository;
    private readonly CustomerService _service;

    public CustomerServiceTests()
    {
        _mockRepository = new Mock<ICustomerRepository>();
        _service = new CustomerService(_mockRepository.Object);
    }

    [Fact]
    public async Task GetCustomerListAsync_ReturnCustomers()
    {
        var expectedAuthors = new List<Customer>
        {
            new Customer { CustomerID = Guid.Parse("6F36DB4C-4BA5-4496-A0C3-0210CF9412AD"), CustomerName = "Customer #1", EmailAddress = "customer1@gmail.com" },
            new Customer { CustomerID = Guid.Parse("2554EF37-C4EC-4C7D-A886-4F144AD567F8"), CustomerName = "Customer #2", EmailAddress = "customer2@gmail.com" },
        };

        _mockRepository.Setup(x => x.GetCustomerList()).ReturnsAsync(expectedAuthors);

        var result = await _service.GetCustomerList();

        Assert.NotNull(result);
        Assert.Equal(2, result.Count());
        Assert.Equal(expectedAuthors, result);
    }
}
