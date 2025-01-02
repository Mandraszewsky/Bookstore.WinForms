using Bookstore.ApplicationLayer.Interfaces.AuthorInterfaces;
using Bookstore.DomainLayer.Models;
using Bookstore.InfrastructureLayer.Data;
using Microsoft.Data.SqlClient;

namespace Bookstore.InfrastructureLayer.Repositories;

public class AuthorRepository : IAuthorRepository
{
    private readonly string connectionString = DatabaseConfig.ConnectionString;

    public async Task<List<Author>> GetAuthorList()
    {
        var authorList = new List<Author>();

        SqlConnection conn = new SqlConnection(connectionString);

        string querySQL = "SELECT AuthorId, AuthorName FROM Authors ORDER BY AuthorName";

        try
        {
            await conn.OpenAsync();

            var command = new SqlCommand(querySQL, conn);
            var dataReader = await command.ExecuteReaderAsync();

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

            await conn.CloseAsync();

            return authorList;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
}