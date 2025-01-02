using Bookstore.ApplicationLayer.Interfaces.CustomerInterfaces;
using Bookstore.DomainLayer.Models;
using Microsoft.Data.SqlClient;

namespace Bookstore.InfrastructureLayer.Repositories;

public class CustomerRepository : ICustomerRepository
{
    private readonly string connectionString = @"Data Source=DESKTOP-I57J3OL;Initial Catalog=BookstoreDB;User Id=sa;Password=sa1234;Integrated Security=True;MultipleActiveResultSets=true;TrustServerCertificate=True;";

    public async Task<List<Customer>> GetCustomerList()
    {
        var customerList = new List<Customer>();

        SqlConnection conn = new SqlConnection(connectionString);

        string querySQL = "SELECT CustomerID, CustomerName, EmailAddress FROM Customers ORDER BY CustomerName";

        try
        {
            conn.Open();

            var command = new SqlCommand(querySQL, conn);
            var dataReader = command.ExecuteReader();

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

            conn.Close();

            return customerList;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
}
