using Bookstore.ApplicationLayer.Interfaces.ReservationInterfaces;
using Bookstore.Domain.Models;

namespace Bookstore.WinForms.Forms.ReservationForms;

public partial class ReservationForm : Form
{
    private readonly IReservationService _reservationService;

    public ReservationForm(IReservationService reservationService)
    {
        _reservationService = reservationService;

        InitializeComponent();
        FillReservationsGridView();
    }

    void FillReservationsGridView()
    {
        var reservations = new List<Reservation>();

        reservations = _reservationService.GetReservations();

        reservationsDataGridView.DataSource = reservations;
    }
}
