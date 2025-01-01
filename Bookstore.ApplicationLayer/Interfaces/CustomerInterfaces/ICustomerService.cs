using Bookstore.DomainLayer.Models;

namespace Bookstore.ApplicationLayer.Interfaces.CustomerInterfaces;

public interface ICustomerService
{
    List<Customer> GetCustomerList();
}
