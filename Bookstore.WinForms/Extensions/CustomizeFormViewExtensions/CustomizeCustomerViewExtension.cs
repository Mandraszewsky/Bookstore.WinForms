namespace Bookstore.WinForms.Extensions.CustomizeFormViewExtensions;

public static class CustomizeCustomerViewExtension
{
    public static void CustomizeCustomersGridView(this DataGridView booksDataGridView)
    {
        booksDataGridView.Columns[0].HeaderText = "Id";
        booksDataGridView.Columns[1].HeaderText = "Name";
        booksDataGridView.Columns[2].HeaderText = "Email";

        booksDataGridView.Columns[0].Width = 50;
        booksDataGridView.Columns[1].Width = 130;
        booksDataGridView.Columns[2].Width = 145;
    }
}
