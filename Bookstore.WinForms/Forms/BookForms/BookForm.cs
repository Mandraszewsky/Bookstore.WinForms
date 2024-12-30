using Bookstore.ApplicationLayer.Interfaces.BookInterfaces;
using Bookstore.Domain.Models;

namespace Bookstore.WinForms.Forms.BookForms;

public partial class BookForm : Form
{
    private readonly IBookService _bookService;
    private readonly IAuthorService _authorService;

    public BookForm(IBookService bookService, IAuthorService authorService)
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

    private void BooksForm_Activated(object sender, EventArgs e)
    {
        FillBooksGridView();
    }

    private void ChildForm_FormClosed(object sender, FormClosedEventArgs e)
    {
        FillBooksGridView();
    }

    private void addBookButton_Click(object sender, EventArgs e)
    {
        AddBookForm addBookForm = new AddBookForm(_bookService, _authorService);
        addBookForm.FormClosed += ChildForm_FormClosed;
        addBookForm.ShowDialog();
    }

    private void editBookButton_Click(object sender, EventArgs e)
    {
        var bookId = (Guid)booksDataGridView.CurrentRow.Cells[0].Value;

        EditBookForm editBookForm = new EditBookForm(bookId, _bookService, _authorService);
        editBookForm.FormClosed += ChildForm_FormClosed;
        editBookForm.ShowDialog();
    }

    private void removeBookButton_Click(object sender, EventArgs e)
    {
        var bookId = (Guid)booksDataGridView.CurrentRow.Cells[0].Value;
        var bookTitle = (string)booksDataGridView.CurrentRow.Cells[2].Value;

        var result = MessageBox.Show($"You want to delete the book titled: {bookTitle}?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        if (result == DialogResult.Yes)
        {
            _bookService.DeleteBook(bookId);

            FillBooksGridView();
        }
    }
}
