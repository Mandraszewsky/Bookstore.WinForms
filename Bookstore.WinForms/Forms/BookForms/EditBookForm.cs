using Bookstore.ApplicationLayer.Interfaces.AuthorInterfaces;
using Bookstore.ApplicationLayer.Interfaces.BookInterfaces;
using Bookstore.ApplicationLayer.Validators;
using Bookstore.DomainLayer.Models;

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

    private async void FillBookData()
    {
        var book = new Book();
        var authors = new List<Author>();

        book = await _bookService.GetBookById(bookId);
        authors = await _authorService.GetAuthorList();

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

    private async void updateBookButton_Click(object sender, EventArgs e)
    {
        var book = new Book
        {
            BookId = bookId,
            ISBN = bookISBNTextBox.Text,
            Title = bookTitleTextBox.Text,
            Description = bookDescriptionTextBox.Text,
            AuthorName = bookAuthorComboBox.Text,
            PagesNumber = Convert.ToInt32(bookPageNumberTextBox.Text),
            Quantity = Convert.ToInt32(bookQuantityTextBox.Text),
            PublicationDate = bookPublicationDateDateTimePicker.Value,
        };

        var validator = new BookValidator();
        var validatorResults = validator.Validate(book);

        if (!validatorResults.IsValid)
        {
            string errorMessages = string.Join(Environment.NewLine, validatorResults.Errors.Select(error => error.ErrorMessage));
            MessageBox.Show(errorMessages, "Validation error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        else
        {
            await _bookService.UpdateBook(book);
            this.Close();
        }
    }
}
