using Bookstore.ApplicationLayer.Interfaces.AuthorInterfaces;
using Bookstore.DomainLayer.Models;
using Bookstore.WinForms.Extensions.CustomizeFormViewExtensions;

namespace Bookstore.WinForms.Forms.AuthorForms;

public partial class AuthorForm : Form
{
    private readonly IAuthorService _authorService;

    public AuthorForm(IAuthorService authorService)
    {
        _authorService = authorService;

        InitializeComponent();
        FillAuthorsGridView();

        authorsDataGridView.CustomizeAuthorsGridView();
    }

    void FillAuthorsGridView()
    {
        var authors = new List<Author>();

        authors = _authorService.GetAuthorList();

        authorsDataGridView.DataSource = authors;
    }
}
