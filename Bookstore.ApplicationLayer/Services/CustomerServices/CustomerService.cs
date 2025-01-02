using Bookstore.ApplicationLayer.Interfaces.CustomerInterfaces;
using Bookstore.DomainLayer.Models;

namespace Bookstore.ApplicationLayer.Services.CustomerServices;

public class CustomerService : ICustomerService
{
    private readonly ICustomerRepository _customerRepository;

    public CustomerService(ICustomerRepository customerRepository)
    {
        _customerRepository = customerRepository;
    }

    public async Task<List<Customer>> GetCustomerList()
    {
        return await _customerRepository.GetCustomerList();
    }
}
