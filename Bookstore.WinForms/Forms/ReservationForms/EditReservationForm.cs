using Bookstore.ApplicationLayer.Interfaces.ReservationInterfaces;
using Bookstore.ApplicationLayer.Validators;
using Bookstore.DomainLayer.Enums;
using Bookstore.DomainLayer.Models;

namespace Bookstore.WinForms.Forms.ReservationForms;

public partial class EditReservationForm : Form
{
    private readonly IReservationService _reservationService;
    private readonly Guid reservationId;

    public EditReservationForm(Guid selectedId, IReservationService reservationService)
    {
        _reservationService = reservationService;
        reservationId = selectedId;

        InitializeComponent();
        FillReservationData();
    }

    private async void FillReservationData()
    {
        var reservation = new Reservation();

        reservation = await _reservationService.GetReservationById(reservationId);

        reservationDateDateTimePicker.Value = Convert.ToDateTime(reservation.ReservationDate);

        foreach (var (index, status) in Enum.GetValues(typeof(ReservationStatusEnum)).Cast<ReservationStatusEnum>().Select((status, index) => (index, status)))
        {
            reservationStatusComboBox.Items.Add(status);

            if (reservation.ReservationStatus.Equals(status))
                reservationStatusComboBox.SelectedIndex = index;
        }
    }

    private void updateReservationButton_Click(object sender, EventArgs e)
    {
        var reservation = new Reservation
        {
            ReservationID = reservationId,
            ReservationDate = reservationDateDateTimePicker.Value,
            ReservationStatus = (ReservationStatusEnum)Enum.Parse(typeof(ReservationStatusEnum), reservationStatusComboBox.Text)
        };

        var validator = new ReservationUpdateValidator();
        var validatorResults = validator.Validate(reservation);

        if (!validatorResults.IsValid)
        {
            string errorMessages = string.Join(Environment.NewLine, validatorResults.Errors.Select(error => error.ErrorMessage));
            MessageBox.Show(errorMessages, "Validation error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        else
        {
            _reservationService.UpdateReservation(reservation);
            this.Close();
        }
    }
}
