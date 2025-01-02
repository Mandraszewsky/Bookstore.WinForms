using Bookstore.ApplicationLayer.Interfaces.AuthorInterfaces;
using Bookstore.ApplicationLayer.Interfaces.BookInterfaces;
using Bookstore.ApplicationLayer.Validators;
using Bookstore.DomainLayer.Models;

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

    private async void FillAuthorComboBox()
    {
        var authors = new List<Author>();

        authors = await _authorService.GetAuthorList();

        foreach (var author in authors)
        {
            bookAuthorComboBox.Items.Add(author.AuthorName!);
        }

        bookAuthorComboBox.SelectedIndex = 0;
    }

    private async void addBookButton_Click(object sender, EventArgs e)
    {
        // //////////// quantity and pages should be as string in Book entity to better fluent validation (just note for future)
        var intQuantityParser = int.TryParse(bookQuantityTextBox.Text?.ToString(), out _);
        var intPagesNumberParser = int.TryParse(bookPageNumberTextBox.Text?.ToString(), out _);

        if (!intQuantityParser || !intPagesNumberParser)
        {
            MessageBox.Show("Quantity & Pages must be convertible to an integer.", "Validation error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        // ////////////

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

        var validator = new BookValidator();
        var validatorResults = validator.Validate(book);

        if (!validatorResults.IsValid)
        {
            string errorMessages = string.Join(Environment.NewLine, validatorResults.Errors.Select(error => error.ErrorMessage));
            MessageBox.Show(errorMessages, "Validation error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        else
        {
            await _bookService.CreateBook(book);
            this.Close();
        }
    }
}
