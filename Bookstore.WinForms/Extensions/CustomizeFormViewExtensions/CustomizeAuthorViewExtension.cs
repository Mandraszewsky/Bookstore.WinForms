namespace Bookstore.WinForms.Extensions.CustomizeFormViewExtensions;

public static class CustomizeAuthorViewExtension
{
    public static void CustomizeAuthorsGridView(this DataGridView booksDataGridView)
    {
        booksDataGridView.Columns[0].HeaderText = "Id";
        booksDataGridView.Columns[1].HeaderText = "Name";

        booksDataGridView.Columns[0].Width = 50;
        booksDataGridView.Columns[1].Width = 130;
    }
}
