using Bookstore.ApplicationLayer.Interfaces.BookInterfaces;
using Bookstore.Domain.Models;

namespace Bookstore.WinForms;

public partial class BooksForm : Form
{
    private readonly IBookService _bookService;

    public BooksForm(IBookService bookService)
    {
        _bookService = bookService;

        InitializeComponent();
        FillBooksGridView();
    }

    void FillBooksGridView()
    {
        List<Book> books = new List<Book>();

        books = _bookService.GetBooksAsync();

        booksDataGridView.DataSource = books;
    }
}
