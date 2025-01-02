using Bookstore.ApplicationLayer.Interfaces.BookInterfaces;
using Bookstore.ApplicationLayer.Interfaces.ReservationInterfaces;
using Bookstore.DomainLayer.Models;
using Microsoft.IdentityModel.Tokens;

namespace Bookstore.WinForms.Forms.ReservationForms;

public partial class ReservationDetailsAddBookForm : Form
{
    private readonly IReservationDetailService _reservationDetailService;
    private readonly IBookService _bookService;
    private readonly Guid reservationId;

    private List<Book> reservationBooks = new List<Book>();
    private BindingSource reservationBindingSource = new BindingSource();

    public ReservationDetailsAddBookForm(Guid selectedId, IReservationDetailService reservationDetailService, IBookService bookService)
    {
        _reservationDetailService = reservationDetailService;
        _bookService = bookService;
        reservationId = selectedId;

        InitializeComponent();
        FillReservationDetailsGridView();
    }

    private async void FillReservationDetailsGridView()
    {
        reservationBooks = await _bookService.GetBooksAsync();

        reservationBindingSource.DataSource = reservationBooks;
        reservationBooksDataGridView.DataSource = reservationBindingSource;
    }

    private void addBookToReservationButton_Click(object sender, EventArgs e)
    {
        var bookId = (Guid)reservationBooksDataGridView.CurrentRow.Cells[0].Value;

        var reservationDetail = new ReservationDetail
        {
            ReservationID = reservationId,
            BookID = bookId
        };

        _reservationDetailService.AddBookToReservation(reservationDetail);

        this.Close();
    }

    private void reservationBookFilterTextBox_TextChanged(object sender, EventArgs e)
    {
        var filterList = reservationBindingSource.DataSource as List<Book>;

        var filterTitleText = reservationBookSearchNameTextBox.Text.ToLower();
        var filterISBNText = reservationBookSearchISBNTextBox.Text.ToLower();

        if (!string.IsNullOrWhiteSpace(filterTitleText) && !filterList.IsNullOrEmpty())
            filterList = filterList!.Where(x => x.Title!.ToLower().Contains(filterTitleText)).ToList();

        if (!string.IsNullOrWhiteSpace(filterISBNText) && !filterList.IsNullOrEmpty())
            filterList = filterList!.Where(x => x.ISBN!.ToLower().Contains(filterISBNText)).ToList();

        reservationBindingSource.DataSource = filterList;

        if (string.IsNullOrWhiteSpace(filterTitleText) && string.IsNullOrWhiteSpace(filterISBNText))
            reservationBindingSource.DataSource = reservationBooks;
        else
            reservationBindingSource.DataSource = filterList;
    }
}
