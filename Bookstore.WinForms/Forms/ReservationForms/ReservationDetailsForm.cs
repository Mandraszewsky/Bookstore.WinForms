using Bookstore.ApplicationLayer.Interfaces.BookInterfaces;
using Bookstore.ApplicationLayer.Interfaces.ReservationInterfaces;
using Bookstore.DomainLayer.Models;
using Bookstore.WinForms.Extensions.CustomizeFormViewExtensions;

namespace Bookstore.WinForms.Forms.ReservationForms;

public partial class ReservationDetailsForm : Form
{
    private readonly IReservationDetailService _reservationDetailService;
    private readonly IBookService _bookService;
    private readonly Guid reservationId;

    public ReservationDetailsForm(Guid selectedId, IReservationDetailService reservationDetailService, IBookService bookService)
    {
        _reservationDetailService = reservationDetailService;
        _bookService = bookService;
        reservationId = selectedId;

        InitializeComponent();
        FillReservationDetailsGridView();
    }

    private async void FillReservationDetailsGridView()
    {
        var reservationDetails = new List<ReservationDetail>();

        reservationDetails = await _reservationDetailService.GetReservationDetailsForReservation(reservationId);

        reservationDetailsDataGridView.DataSource = reservationDetails;

        reservationDetailsDataGridView.CustomizeReservationDetailsGridView();
    }

    private void ChildForm_FormClosed(object sender, FormClosedEventArgs e)
    {
        FillReservationDetailsGridView();
    }

    private void addReservationBookButton_Click(object sender, EventArgs e)
    {
        ReservationDetailsAddBookForm reservationDetailsAddBookForm = new ReservationDetailsAddBookForm(reservationId, _reservationDetailService, _bookService);
        reservationDetailsAddBookForm.FormClosed += ChildForm_FormClosed;
        reservationDetailsAddBookForm.ShowDialog();
    }

    private void removeReservationBookButton_Click(object sender, EventArgs e)
    {
        var reservationDetailId = (Guid)reservationDetailsDataGridView.CurrentRow.Cells[0].Value;
        var bookTitle = (string)reservationDetailsDataGridView.CurrentRow.Cells[4].Value;

        var result = MessageBox.Show($"You want to delete the book titled: {bookTitle} from reservation?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        if (result == DialogResult.Yes)
        {
            _reservationDetailService.RemoveBookFromReservation(reservationDetailId);

            FillReservationDetailsGridView();
        }
    }
}
