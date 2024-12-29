using Bookstore.ApplicationLayer.Interfaces.BookInterfaces;
using Bookstore.Domain.Models;

namespace Bookstore.WinForms;

public partial class EditBookForm : Form
{
    private readonly IBookService _bookService;
    private readonly IAuthorService _authorService;
    private readonly Guid bookId;

    public EditBookForm(Guid selectedId, IBookService bookService, IAuthorService authorService)
    {
        _bookService = bookService;
        _authorService = authorService;
        bookId = selectedId;

        InitializeComponent();
        FillBookData();
    }

    void FillBookData()
    {
        var book = new Book();
        var authors = new List<Author>();

        book = _bookService.GetBookById(bookId).Result;
        authors = _authorService.GetAuthorList();

        bookISBNTextBox.Text = book.ISBN;
        bookTitleTextBox.Text = book.Title;
        bookDescriptionTextBox.Text = book.Description;
        bookPublicationDateDateTimePicker.Value = Convert.ToDateTime(book.PublicationDate);
        bookPageNumberTextBox.Text = book.PagesNumber.ToString();
        bookQuantityTextBox.Text = book.Quantity.ToString();

        foreach (var (index, author) in authors.Select((author, index) => (index, author)))
        {
            bookAuthorComboBox.Items.Add(author.AuthorName!);

            if (book.AuthorName!.Equals(author.AuthorName))
                bookAuthorComboBox.SelectedIndex = index;
        }
    }
}
