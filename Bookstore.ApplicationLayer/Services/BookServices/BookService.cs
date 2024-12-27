using Bookstore.ApplicationLayer.Interfaces.BookInterfaces;
using Bookstore.Domain.Models;
using Microsoft.Data.SqlClient;

namespace Bookstore.ApplicationLayer.Services.BookServices;

public class BookService : IBookService
{
    public List<Book> GetBooksAsync()
    {
        List<Book> bookList = new List<Book>();

        string connectionString = @"Data Source=DESKTOP-I57J3OL;Initial Catalog=BookstoreDB;User Id=sa;Password=sa1234;Integrated Security=True;MultipleActiveResultSets=true;TrustServerCertificate=True;";
        SqlConnection conn = new SqlConnection(connectionString);

        string querySQL = "SELECT BookId, ISBN, Title, Description, PagesNumber, Quantity, FirstName, LastName FROM GetBooksWithAuthorsView";

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
                    book.Author = $"{dataReader["FirstName"]} {dataReader["LastName"]}";
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
