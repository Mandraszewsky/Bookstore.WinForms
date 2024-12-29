using Bookstore.ApplicationLayer.Interfaces.BookInterfaces;
using Bookstore.Domain.Models;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Bookstore.ApplicationLayer.Services.BookServices;

public class BookService : IBookService
{
    private readonly string connectionString = @"Data Source=DESKTOP-I57J3OL;Initial Catalog=BookstoreDB;User Id=sa;Password=sa1234;Integrated Security=True;MultipleActiveResultSets=true;TrustServerCertificate=True;";

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
            conn.Open();

            await command.ExecuteNonQueryAsync();

            conn.Close();
        } 
        catch (Exception ex) 
        {
            throw new Exception(ex.Message);
        }


    }

    public List<Book> GetBooksAsync()
    {
        List<Book> bookList = new List<Book>();

        SqlConnection conn = new SqlConnection(connectionString);

        string querySQL = "SELECT BookId, ISBN, Title, Description, PagesNumber, Quantity, AuthorName FROM GetBooksWithAuthorsView";

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
                    book.PublicationDate = DateTime.Now;
                    //book.PublicationDate = Convert.ToDateTime(dataReader["PublicationDate"]);

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
