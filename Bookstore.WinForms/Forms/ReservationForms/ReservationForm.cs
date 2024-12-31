using Bookstore.ApplicationLayer.Interfaces.ReservationInterfaces;
using Bookstore.Domain.Models;

namespace Bookstore.WinForms.Forms.ReservationForms;

public partial class ReservationForm : Form
{
    private readonly IReservationService _reservationService;
    private readonly IReservationDetailService _reservationDetailService;

    public ReservationForm(IReservationService reservationService, IReservationDetailService reservationDetailService)
    {
        _reservationService = reservationService;
        _reservationDetailService = reservationDetailService;

        InitializeComponent();
        FillReservationsGridView();
    }

    void FillReservationsGridView()
    {
        var reservations = new List<Reservation>();

        reservations = _reservationService.GetReservations();

        reservationsDataGridView.DataSource = reservations;
    }

    private void reservationDetailsButton_Click(object sender, EventArgs e)
    {
        var reservationId = (Guid)reservationsDataGridView.CurrentRow.Cells[0].Value;

        ReservationDetailsForm reservationDetailsForm = new ReservationDetailsForm(reservationId, _reservationDetailService);
        reservationDetailsForm.ShowDialog();
    }
}
