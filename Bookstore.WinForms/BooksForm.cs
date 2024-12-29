using Bookstore.ApplicationLayer.Interfaces.BookInterfaces;
using Bookstore.Domain.Models;

namespace Bookstore.WinForms;

public partial class BooksForm : Form
{
    private readonly IBookService _bookService;
    private readonly IAuthorService _authorService;

    public BooksForm(IBookService bookService, IAuthorService authorService)
    {
        _bookService = bookService;
        _authorService = authorService;

        InitializeComponent();
        FillBooksGridView();
    }

    void FillBooksGridView()
    {
        var books = new List<Book>();

        books = _bookService.GetBooksAsync();

        booksDataGridView.DataSource = books;
    }

    private void addBookButton_Click(object sender, EventArgs e)
    {
        AddBookForm addBookForm = new AddBookForm(_bookService, _authorService);
        addBookForm.ShowDialog();
    }

    private void editBookButton_Click(object sender, EventArgs e)
    {
        var bookId = (Guid)booksDataGridView.CurrentRow.Cells[0].Value; 

        EditBookForm editBookForm = new EditBookForm(bookId, _bookService, _authorService);
        editBookForm.ShowDialog();
    }

    private void BooksForm_Activated(object sender, EventArgs e)
    {
        FillBooksGridView();
    }
}
