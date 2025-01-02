using Bookstore.ApplicationLayer.Interfaces.BookInterfaces;
using Bookstore.DomainLayer.Models;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Bookstore.InfrastructureLayer.Repositories;

public class BookRepository : IBookRepository
{
    private readonly string connectionString = @"Data Source=DESKTOP-I57J3OL;Initial Catalog=BookstoreDB;User Id=sa;Password=sa1234;Integrated Security=True;MultipleActiveResultSets=true;TrustServerCertificate=True;";

    public Task CreateBook(Book book)
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
            conn.Open();

            command.ExecuteNonQuery();

            conn.Close();
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }

        return Task.CompletedTask;
    }

    public Task UpdateBook(Book book)
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
            conn.Open();

            command.ExecuteNonQuery();

            conn.Close();
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }

        return Task.CompletedTask;
    }

    public Task DeleteBook(Guid id)
    {
        SqlConnection conn = new SqlConnection(connectionString);

        var command = new SqlCommand("DeleteBook", conn);
        command.CommandType = CommandType.StoredProcedure;

        command.Parameters.Add(new SqlParameter("@BookId", id));

        try
        {
            conn.Open();

            command.ExecuteNonQuery();

            conn.Close();
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }

        return Task.CompletedTask;
    }

    public async Task<Book> GetBookById(Guid id)
    {
        Book book = new Book();

        SqlConnection conn = new SqlConnection(connectionString);

        string querySQL = $"SELECT BookId, ISBN, Title, Description, PagesNumber, Quantity, AuthorName FROM GetBooksWithAuthorsView WHERE BookId = '{id}'";

        try
        {
            conn.Open();

            var command = new SqlCommand(querySQL, conn);
            var dataReader = command.ExecuteReader();

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

            conn.Close();

            return book;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public async Task<List<Book>> GetBooksAsync()
    {
        List<Book> bookList = new List<Book>();

        SqlConnection conn = new SqlConnection(connectionString);

        string querySQL = "SELECT BookId, ISBN, Title, Description, PagesNumber, Quantity, PublicationDate, AuthorName FROM GetBooksWithAuthorsView";

        try
        {
            conn.Open();

            var command = new SqlCommand(querySQL, conn);
            var dataReader = command.ExecuteReader();

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

            conn.Close();

            return bookList;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
}
