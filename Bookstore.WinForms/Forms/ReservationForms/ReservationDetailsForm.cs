using Bookstore.ApplicationLayer.Interfaces.ReservationInterfaces;
using Bookstore.Domain.Models;

namespace Bookstore.WinForms.Forms.ReservationForms;

public partial class ReservationDetailsForm : Form
{
    private readonly IReservationDetailService _reservationDetailService;
    private readonly Guid reservationId;

    public ReservationDetailsForm(Guid selectedId, IReservationDetailService reservationDetailService)
    {
        _reservationDetailService = reservationDetailService;
        reservationId = selectedId;

        InitializeComponent();
        FillReservationDetailsGridView();
    }

    void FillReservationDetailsGridView()
    {
        var reservationDetails = new List<ReservationDetail>();

        reservationDetails = _reservationDetailService.GetReservationDetailsForReservation(reservationId);

        reservationDetailsDataGridView.DataSource = reservationDetails;
    }
}
