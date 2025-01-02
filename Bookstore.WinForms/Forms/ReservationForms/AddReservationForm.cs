using Bookstore.ApplicationLayer.Interfaces.CustomerInterfaces;
using Bookstore.ApplicationLayer.Interfaces.ReservationInterfaces;
using Bookstore.DomainLayer.Enums;
using Bookstore.DomainLayer.Models;

namespace Bookstore.WinForms.Forms.ReservationForms;

public partial class AddReservationForm : Form
{
    private readonly IReservationService _reservationService;
    private readonly ICustomerService _customerService;

    public AddReservationForm(ICustomerService customerService, IReservationService reservationService)
    {
        _customerService = customerService;
        _reservationService = reservationService;

        InitializeComponent();

        FillCustomerComboBox();
        FillReservationStatusComboBox();
    }

    private async void FillCustomerComboBox()
    {
        var customers = new List<Customer>();

        customers = await _customerService.GetCustomerList();

        foreach (var customer in customers)
        {
            reservationCustomerComboBox.Items.Add(customer.CustomerName!);
        }

        reservationCustomerComboBox.SelectedIndex = 0;
    }

    private void FillReservationStatusComboBox()
    {
        foreach (var status in Enum.GetValues(typeof(ReservationStatusEnum)))
        {
            reservationStatusComboBox.Items.Add(status);
        }

        reservationStatusComboBox.SelectedIndex = 0;
    }

    private async void addReservationButton_Click(object sender, EventArgs e)
    {
        var reservation = new Reservation
        {
            CustomerName = reservationCustomerComboBox.Text,
            ReservationStatus = (ReservationStatusEnum)Enum.Parse(typeof(ReservationStatusEnum), reservationStatusComboBox.Text),
            ReservationDate = reservationDateDateTimePicker.Value,
        };

        await _reservationService.CreateReservation(reservation);

        this.Close();
    }
}
