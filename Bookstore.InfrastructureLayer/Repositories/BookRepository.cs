using Bookstore.ApplicationLayer.Interfaces.BookInterfaces;
using Bookstore.DomainLayer.Models;
using Bookstore.InfrastructureLayer.Data;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Bookstore.InfrastructureLayer.Repositories;

public class BookRepository : IBookRepository
{
    private readonly string connectionString = DatabaseConfig.ConnectionString;

    public async Task CreateBook(Book book)
    {
        SqlConnection conn = new SqlConnection(connectionString);

        var command = new SqlCommand("CreateBook", conn);
        command.CommandType = CommandType.StoredProcedure;

        command.Parameters.Add(new SqlParameter("@ISBN", book.ISBN));
        command.Parameters.Add(new SqlParameter("@Title", book.Title));
        command.Parameters.Add(new SqlParameter("@Description", book.Description));
        command.Parameters.Add(new SqlParameter("@AuthorName", book.AuthorName));
        command.Parameters.Add(new SqlParameter("@PagesNumber", book.PagesNumber));
        command.Parameters.Add(new SqlParameter("@Quantity", book.Quantity));
        command.Parameters.Add(new SqlParameter("PublicationDate", book.PublicationDate));

        try
        {
            await conn.OpenAsync();

            await command.ExecuteNonQueryAsync();

            await conn.CloseAsync();
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public async Task UpdateBook(Book book)
    {
        SqlConnection conn = new SqlConnection(connectionString);

        var command = new SqlCommand("UpdateBook", conn);
        command.CommandType = CommandType.StoredProcedure;

        command.Parameters.Add(new SqlParameter("@BookId", book.BookId));
        command.Parameters.Add(new SqlParameter("@ISBN", book.ISBN));
        command.Parameters.Add(new SqlParameter("@Title", book.Title));
        command.Parameters.Add(new SqlParameter("@Description", book.Description));
        command.Parameters.Add(new SqlParameter("@PagesNumber", book.PagesNumber));
        command.Parameters.Add(new SqlParameter("@Quantity", book.Quantity));
        command.Parameters.Add(new SqlParameter("PublicationDate", book.PublicationDate));

        try
        {
            await conn.OpenAsync();

            await command.ExecuteNonQueryAsync();

            await conn.CloseAsync();
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public async Task DeleteBook(Guid id)
    {
        SqlConnection conn = new SqlConnection(connectionString);

        var command = new SqlCommand("DeleteBook", conn);
        command.CommandType = CommandType.StoredProcedure;

        command.Parameters.Add(new SqlParameter("@BookId", id));

        try
        {
            await conn.OpenAsync();

            await command.ExecuteNonQueryAsync();

            await conn.CloseAsync();
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public async Task<Book> GetBookById(Guid id)
    {
        Book book = new Book();

        SqlConnection conn = new SqlConnection(connectionString);

        string querySQL = $"SELECT BookId, ISBN, Title, Description, PagesNumber, Quantity, AuthorName FROM GetBooksWithAuthorsView WHERE BookId = '{id}'";

        try
        {
            await conn.OpenAsync();

            var command = new SqlCommand(querySQL, conn);
            var dataReader = await command.ExecuteReaderAsync();

            if (dataReader != null)
            {
                while (dataReader.Read())
                {
                    book.BookId = Guid.Parse(dataReader["BookId"].ToString()!);
                    book.ISBN = dataReader["ISBN"].ToString();
                    book.Title = dataReader["Title"].ToString();
                    book.Description = dataReader["Description"].ToString();
                    book.AuthorName = dataReader["AuthorName"].ToString();
                    book.PagesNumber = Convert.ToInt32(dataReader["PagesNumber"]);
                    book.Quantity = Convert.ToInt32(dataReader["Quantity"]);
                    book.PublicationDate = DateTime.Now;
                }
            }

            await conn.CloseAsync();

            return book;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public async Task<List<Book>> GetBookList()
    {
        List<Book> bookList = new List<Book>();

        SqlConnection conn = new SqlConnection(connectionString);

        string querySQL = "SELECT BookId, ISBN, Title, Description, PagesNumber, Quantity, PublicationDate, AuthorName FROM GetBooksWithAuthorsView";

        try
        {
            await conn.OpenAsync();

            var command = new SqlCommand(querySQL, conn);
            var dataReader = await command.ExecuteReaderAsync();

            if (dataReader != null)
            {
                while (dataReader.Read())
                {
                    Book book = new Book();

                    book.BookId = Guid.Parse(dataReader["BookId"].ToString()!);
                    book.ISBN = dataReader["ISBN"].ToString();
                    book.Title = dataReader["Title"].ToString();
                    book.Description = dataReader["Description"].ToString();
                    book.AuthorName = dataReader["AuthorName"].ToString();
                    book.PagesNumber = Convert.ToInt32(dataReader["PagesNumber"]);
                    book.Quantity = Convert.ToInt32(dataReader["Quantity"]);
                    book.PublicationDate = DateTime.Parse(dataReader["PublicationDate"].ToString()!);

                    bookList.Add(book);
                }
            }

            await conn.CloseAsync();

            return bookList;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
}
