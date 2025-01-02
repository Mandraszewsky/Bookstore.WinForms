namespace Bookstore.WinForms.Extensions.CustomizeFormViews;

public static class CustomizeBookViewExtension
{
    public static void CustomizeBooksGridView(this DataGridView booksDataGridView)
    {
        booksDataGridView.Columns[0].HeaderText = "Id";
        booksDataGridView.Columns[1].HeaderText = "ISBN";
        booksDataGridView.Columns[2].HeaderText = "Title";
        booksDataGridView.Columns[3].HeaderText = "Description";
        booksDataGridView.Columns[4].HeaderText = "Author";
        booksDataGridView.Columns[5].HeaderText = "Pages";
        booksDataGridView.Columns[6].HeaderText = "Quantity";
        booksDataGridView.Columns[7].HeaderText = "Publication";

        booksDataGridView.Columns[0].Width = 50;
        booksDataGridView.Columns[1].Width = 100;
        booksDataGridView.Columns[2].Width = 140;
        booksDataGridView.Columns[3].Width = 100;
        booksDataGridView.Columns[4].Width = 100;
        booksDataGridView.Columns[5].Width = 50;
        booksDataGridView.Columns[6].Width = 60;
        booksDataGridView.Columns[7].Width = 75;
    }
}
