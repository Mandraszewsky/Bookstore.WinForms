using Bookstore.WinForms.Forms.AuthorForms;
using Bookstore.WinForms.Forms.BookForms;
using Bookstore.WinForms.Forms.CustomerForms;
using Bookstore.WinForms.Forms.ReservationForms;
using Microsoft.Extensions.DependencyInjection;

namespace Bookstore.WinForms;

public partial class MainForm : Form
{
    private Button currentButton;
    private Form activeForm;

    public MainForm()
    {
        currentButton = new Button();
        activeForm = new Form();

        InitializeComponent();
    }

    private void ActivateButton(object sender, EventArgs e)
    {
        if (sender != null)
        {
            if (currentButton != (Button)sender)
            {
                DisactivateButtons();
                currentButton = (Button)sender;
                currentButton.BackColor = Color.FromArgb(74, 0, 74);
                currentButton.Font = new Font("Arial Rounded MT Bold", 12.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            }
        }
    }

    private void DisactivateButtons()
    {
        foreach (Control button in navigationPanel.Controls)
        {
            if (button.GetType() == typeof(Button))
            {
                button.BackColor = Color.FromArgb(64, 0, 64);
                button.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            }
        }
    }

    private void OpenChildForm(Form childForm, object sender, EventArgs e)
    {
        if (activeForm != null)
        {
            activeForm.Close();
        }

        ActivateButton(sender, e);
        activeForm = childForm;

        childForm.TopLevel = false;
        childForm.FormBorderStyle = FormBorderStyle.None;
        childForm.Dock = DockStyle.Fill;

        this.currentViewPanel.Controls.Add(childForm);
        this.currentViewPanel.Tag = childForm;

        childForm.BringToFront();
        childForm.Show();
        childForm.Focus();
    }

    private void booksButton_Click(object sender, EventArgs e)
    {
        BookForm bookForm = Program.ServiceProvider!.GetRequiredService<BookForm>();
        OpenChildForm(bookForm, sender, e);
    }

    private void reservationsButton_Click(object sender, EventArgs e)
    {
        ReservationForm reservationForm = Program.ServiceProvider!.GetRequiredService<ReservationForm>();
        OpenChildForm(reservationForm, sender, e);
    }

    private void authorsButton_Click(object sender, EventArgs e)
    {
        AuthorForm authorForm = Program.ServiceProvider!.GetRequiredService<AuthorForm>();
        OpenChildForm(authorForm, sender, e);
    }

    private void cutomersButton_Click(object sender, EventArgs e)
    {
        CustomerForm customerForm = Program.ServiceProvider!.GetRequiredService<CustomerForm>();
        OpenChildForm(customerForm, sender, e);
    }
}
