using Bookstore.ApplicationLayer.Interfaces.BookInterfaces;
using Bookstore.Domain.Models;

namespace Bookstore.WinForms;

public partial class AddBookForm : Form
{
    private readonly IBookService _bookService;
    private readonly IAuthorService _authorService;

    public AddBookForm(IBookService bookService, IAuthorService authorService)
    {
        _bookService = bookService;
        _authorService = authorService;

        InitializeComponent();
        FillAuthorComboBox();
    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void addBookButton_Click(object sender, EventArgs e)
    {
        var book = new Book
        {
            ISBN = bookISBNTextBox.Text,
            Title = bookTitleTextBox.Text,
            Description = bookDescriptionTextBox.Text,
            AuthorName = bookAuthorComboBox.Text,
            PagesNumber = Convert.ToInt32(bookPageNumberTextBox.Text),
            Quantity = Convert.ToInt32(bookQuantityTextBox.Text),
            PublicationDate = bookPublicationDateDateTimePicker.Value,
        };

        _bookService.CreateBook(book);

        this.Close();
    }

    private void FillAuthorComboBox()
    {
        var authors = new List<Author>();

        authors = _authorService.GetAuthorList();

        foreach (var author in authors)
        {
            bookAuthorComboBox.Items.Add(author.AuthorName!);
        }
    }
}
