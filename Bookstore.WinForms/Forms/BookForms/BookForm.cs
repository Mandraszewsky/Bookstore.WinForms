using Bookstore.ApplicationLayer.Interfaces.AuthorInterfaces;
using Bookstore.ApplicationLayer.Interfaces.BookInterfaces;
using Bookstore.DomainLayer.Models;
using Bookstore.WinForms.Extensions.CustomizeFormViews;
using Microsoft.IdentityModel.Tokens;
using System.Data;

namespace Bookstore.WinForms.Forms.BookForms;

public partial class BookForm : Form
{
    private readonly IBookService _bookService;
    private readonly IAuthorService _authorService;

    private List<Book> books = new List<Book>();
    private BindingSource bindingSource = new BindingSource();

    public BookForm(IBookService bookService, IAuthorService authorService)
    {
        _bookService = bookService;
        _authorService = authorService;

        InitializeComponent();
        FillBooksGridView();

        booksDataGridView.CustomizeBooksGridView();
    }

    void FillBooksGridView()
    {
        books = _bookService.GetBooksAsync();

        bindingSource.DataSource = books;
        booksDataGridView.DataSource = bindingSource;
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

    private void resetBookFilterButton_Click(object sender, EventArgs e)
    {
        bookSearchNameTextBox.Text = string.Empty;
        bookSearchISBNTextBox.Text = string.Empty;

        bookSearchFromDateTimePicker.Value = DateTime.Now;
        bookSearchToDateTimePicker.Value = DateTime.Now;

        bindingSource.DataSource = books;
    }

    private void bookFilterTextBox_TextChanged(object sender, EventArgs e)
    {
        var filterList = bindingSource.DataSource as List<Book>;

        var filterTitleText = bookSearchNameTextBox.Text.ToLower();
        var filterISBNText = bookSearchISBNTextBox.Text.ToLower();

        if (!string.IsNullOrWhiteSpace(filterTitleText) && !filterList.IsNullOrEmpty())
            filterList = filterList!.Where(x => x.Title!.ToLower().Contains(filterTitleText)).ToList();

        if (!string.IsNullOrWhiteSpace(filterISBNText) && !filterList.IsNullOrEmpty())
            filterList = filterList!.Where(x => x.ISBN!.ToLower().Contains(filterISBNText)).ToList();

        bindingSource.DataSource = filterList;

        if (string.IsNullOrWhiteSpace(filterTitleText) && string.IsNullOrWhiteSpace(filterISBNText))
            bindingSource.DataSource = books;
        else
            bindingSource.DataSource = filterList;
    }

    private void bookFilterDateTimePicker_ValueChanged(object sender, EventArgs e)
    {
        var filterList = bindingSource.DataSource as List<Book>;

        var filterFromDate = bookSearchFromDateTimePicker.Value;
        var filterToDate = bookSearchToDateTimePicker.Value;

        if (!filterList.IsNullOrEmpty())
            filterList = filterList!.Where(x => x.PublicationDate >= filterFromDate && x.PublicationDate <= filterToDate).ToList();

        bindingSource.DataSource = filterList;
    }
}
