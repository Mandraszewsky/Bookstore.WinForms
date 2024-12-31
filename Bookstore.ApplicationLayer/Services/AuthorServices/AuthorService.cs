using Bookstore.ApplicationLayer.Interfaces.AuthorInterfaces;
using Bookstore.Domain.Models;
using Microsoft.Data.SqlClient;

namespace Bookstore.ApplicationLayer.Services.AuthorServices;

public class AuthorService : IAuthorService
{
    private readonly string connectionString = @"Data Source=DESKTOP-I57J3OL;Initial Catalog=BookstoreDB;User Id=sa;Password=sa1234;Integrated Security=True;MultipleActiveResultSets=true;TrustServerCertificate=True;";

    public List<Author> GetAuthorList()
    {
        var authorList = new List<Author>();

        SqlConnection conn = new SqlConnection(connectionString);

        string querySQL = "SELECT AuthorId, AuthorName FROM Authors ORDER BY AuthorName";

        try
        {
            conn.Open();

            var command = new SqlCommand(querySQL, conn);
            var dataReader = command.ExecuteReader();

            if (dataReader != null)
            {
                while (dataReader.Read())
                {
                    var author = new Author();

                    author.AuthorId = Guid.Parse(dataReader["AuthorId"].ToString()!);
                    author.AuthorName = dataReader["AuthorName"].ToString();

                    authorList.Add(author);
                }
            }

            conn.Close();

            return authorList;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
}
