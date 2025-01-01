namespace Bookstore.WinForms.Forms.ReservationForms;

partial class ReservationDetailsAddBookForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        reservationBooksDataGridView = new DataGridView();
        addBookToReservationButton = new Button();
        reservationBookSearchISBNLabel = new Label();
        reservationBookSearchNameLabel = new Label();
        reservationBookSearchISBNTextBox = new TextBox();
        reservationBookSearchNameTextBox = new TextBox();
        ((System.ComponentModel.ISupportInitialize)reservationBooksDataGridView).BeginInit();
        SuspendLayout();
        // 
        // reservationBooksDataGridView
        // 
        reservationBooksDataGridView.AllowUserToAddRows = false;
        reservationBooksDataGridView.AllowUserToDeleteRows = false;
        reservationBooksDataGridView.AllowUserToOrderColumns = true;
        reservationBooksDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        reservationBooksDataGridView.Location = new Point(26, 87);
        reservationBooksDataGridView.Name = "reservationBooksDataGridView";
        reservationBooksDataGridView.Size = new Size(510, 249);
        reservationBooksDataGridView.TabIndex = 32;
        // 
        // addBookToReservationButton
        // 
        addBookToReservationButton.Location = new Point(395, 372);
        addBookToReservationButton.Name = "addBookToReservationButton";
        addBookToReservationButton.Size = new Size(141, 40);
        addBookToReservationButton.TabIndex = 33;
        addBookToReservationButton.Text = "Add book";
        addBookToReservationButton.UseVisualStyleBackColor = true;
        addBookToReservationButton.Click += addBookToReservationButton_Click;
        // 
        // reservationBookSearchISBNLabel
        // 
        reservationBookSearchISBNLabel.AutoSize = true;
        reservationBookSearchISBNLabel.Location = new Point(246, 23);
        reservationBookSearchISBNLabel.Name = "reservationBookSearchISBNLabel";
        reservationBookSearchISBNLabel.Size = new Size(89, 15);
        reservationBookSearchISBNLabel.TabIndex = 42;
        reservationBookSearchISBNLabel.Text = "Search by ISBN:";
        // 
        // reservationBookSearchNameLabel
        // 
        reservationBookSearchNameLabel.AutoSize = true;
        reservationBookSearchNameLabel.Location = new Point(26, 23);
        reservationBookSearchNameLabel.Name = "reservationBookSearchNameLabel";
        reservationBookSearchNameLabel.Size = new Size(84, 15);
        reservationBookSearchNameLabel.TabIndex = 41;
        reservationBookSearchNameLabel.Text = "Search by title:";
        // 
        // reservationBookSearchISBNTextBox
        // 
        reservationBookSearchISBNTextBox.Location = new Point(246, 41);
        reservationBookSearchISBNTextBox.Name = "reservationBookSearchISBNTextBox";
        reservationBookSearchISBNTextBox.Size = new Size(179, 23);
        reservationBookSearchISBNTextBox.TabIndex = 40;
        reservationBookSearchISBNTextBox.TextChanged += reservationBookFilterTextBox_TextChanged;
        // 
        // reservationBookSearchNameTextBox
        // 
        reservationBookSearchNameTextBox.Location = new Point(26, 41);
        reservationBookSearchNameTextBox.Name = "reservationBookSearchNameTextBox";
        reservationBookSearchNameTextBox.Size = new Size(179, 23);
        reservationBookSearchNameTextBox.TabIndex = 39;
        reservationBookSearchNameTextBox.TextChanged += reservationBookFilterTextBox_TextChanged;
        // 
        // ReservationDetailsAddBookForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(568, 448);
        Controls.Add(reservationBookSearchISBNLabel);
        Controls.Add(reservationBookSearchNameLabel);
        Controls.Add(reservationBookSearchISBNTextBox);
        Controls.Add(reservationBookSearchNameTextBox);
        Controls.Add(addBookToReservationButton);
        Controls.Add(reservationBooksDataGridView);
        Name = "ReservationDetailsAddBookForm";
        Text = "Add book to reservation";
        ((System.ComponentModel.ISupportInitialize)reservationBooksDataGridView).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private DataGridView reservationBooksDataGridView;
    private Button addBookToReservationButton;
    private Label reservationBookSearchISBNLabel;
    private Label reservationBookSearchNameLabel;
    private TextBox reservationBookSearchISBNTextBox;
    private TextBox reservationBookSearchNameTextBox;
}