using Bookstore.DomainLayer.Models;

namespace Bookstore.ApplicationLayer.Interfaces.CustomerInterfaces;

public interface ICustomerRepository
{
    Task<List<Customer>> GetCustomerList();
}
