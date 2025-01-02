namespace Bookstore.WinForms.Extensions.CustomizeFormViewExtensions;

public static class CustomizeReservationViewExtension
{
    public static void CustomizeReservationsGridView(this DataGridView reservationsDataGridView)
    {
        reservationsDataGridView.Columns[0].HeaderText = "Reservation Id";
        reservationsDataGridView.Columns[1].HeaderText = "Customer Id";
        reservationsDataGridView.Columns[2].HeaderText = "Customer Name";
        reservationsDataGridView.Columns[3].HeaderText = "Customer Email";
        reservationsDataGridView.Columns[4].HeaderText = "Status";
        reservationsDataGridView.Columns[5].HeaderText = "Date";

        reservationsDataGridView.Columns[0].Width = 110;
        reservationsDataGridView.Columns[1].Width = 110;
        reservationsDataGridView.Columns[2].Width = 130;
        reservationsDataGridView.Columns[3].Width = 145;
        reservationsDataGridView.Columns[4].Width = 80;
        reservationsDataGridView.Columns[5].Width = 100;
    }
}
