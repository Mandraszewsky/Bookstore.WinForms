using Bookstore.ApplicationLayer.Interfaces.CustomerInterfaces;
using Bookstore.DomainLayer.Models;
using Bookstore.InfrastructureLayer.Data;
using Microsoft.Data.SqlClient;

namespace Bookstore.InfrastructureLayer.Repositories;

public class CustomerRepository : ICustomerRepository
{
    private readonly string connectionString = DatabaseConfig.ConnectionString;

    public async Task<List<Customer>> GetCustomerList()
    {
        var customerList = new List<Customer>();

        SqlConnection conn = new SqlConnection(connectionString);

        string querySQL = "SELECT CustomerID, CustomerName, EmailAddress FROM Customers ORDER BY CustomerName";

        try
        {
            await conn.OpenAsync();

            var command = new SqlCommand(querySQL, conn);
            var dataReader = await command.ExecuteReaderAsync();

            if (dataReader != null)
            {
                while (dataReader.Read())
                {
                    var customer = new Customer();

                    customer.CustomerID = Guid.Parse(dataReader["CustomerID"].ToString()!);
                    customer.CustomerName = dataReader["CustomerName"].ToString();
                    customer.EmailAddress = dataReader["EmailAddress"].ToString();

                    customerList.Add(customer);
                }
            }

            await conn.CloseAsync();

            return customerList;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
}
