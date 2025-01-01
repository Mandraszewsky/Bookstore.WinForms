using Bookstore.ApplicationLayer.Interfaces.CustomerInterfaces;
using Bookstore.ApplicationLayer.Interfaces.ReservationInterfaces;
using Bookstore.DomainLayer.Enums;
using Bookstore.DomainLayer.Models;

namespace Bookstore.WinForms.Forms.ReservationForms;

public partial class ReservationForm : Form
{
    private readonly IReservationService _reservationService;
    private readonly IReservationDetailService _reservationDetailService;
    private readonly ICustomerService _customerService;

    public ReservationForm(IReservationService reservationService, IReservationDetailService reservationDetailService, ICustomerService customerService)
    {
        _reservationService = reservationService;
        _reservationDetailService = reservationDetailService;
        _customerService = customerService;

        InitializeComponent();
        FillReservationsGridView();
    }

    void FillReservationsGridView()
    {
        var reservations = new List<Reservation>();

        reservations = _reservationService.GetReservations();

        reservationsDataGridView.DataSource = reservations;
    }

    private void ChildForm_FormClosed(object sender, FormClosedEventArgs e)
    {
        FillReservationsGridView();
    }

    private void reservationDetailsButton_Click(object sender, EventArgs e)
    {
        var reservationId = (Guid)reservationsDataGridView.CurrentRow.Cells[0].Value;

        ReservationDetailsForm reservationDetailsForm = new ReservationDetailsForm(reservationId, _reservationDetailService);
        reservationDetailsForm.ShowDialog();
    }

    private void addReservationButton_Click(object sender, EventArgs e)
    {
        AddReservationForm addReservationForm = new AddReservationForm(_customerService, _reservationService);
        addReservationForm.FormClosed += ChildForm_FormClosed;
        addReservationForm.ShowDialog();
    }

    private void editReservationButton_Click(object sender, EventArgs e)
    {
        var reservationId = (Guid)reservationsDataGridView.CurrentRow.Cells[0].Value;

        EditReservationForm editReservationForm = new EditReservationForm(reservationId, _reservationService);
        editReservationForm.FormClosed += ChildForm_FormClosed;
        editReservationForm.ShowDialog();
    }
}
