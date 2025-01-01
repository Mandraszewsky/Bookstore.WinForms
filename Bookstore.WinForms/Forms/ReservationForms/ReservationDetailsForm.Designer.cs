namespace Bookstore.WinForms.Forms.ReservationForms;

partial class ReservationDetailsForm
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
        reservationDetailsDataGridView = new DataGridView();
        cancelBookButton = new Button();
        addReservationBookButton = new Button();
        removeReservationBookButton = new Button();
        ((System.ComponentModel.ISupportInitialize)reservationDetailsDataGridView).BeginInit();
        SuspendLayout();
        // 
        // reservationDetailsDataGridView
        // 
        reservationDetailsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        reservationDetailsDataGridView.Location = new Point(42, 12);
        reservationDetailsDataGridView.Name = "reservationDetailsDataGridView";
        reservationDetailsDataGridView.Size = new Size(484, 324);
        reservationDetailsDataGridView.TabIndex = 36;
        // 
        // cancelBookButton
        // 
        cancelBookButton.Location = new Point(416, 375);
        cancelBookButton.Name = "cancelBookButton";
        cancelBookButton.Size = new Size(110, 31);
        cancelBookButton.TabIndex = 91;
        cancelBookButton.Text = "Cancel";
        cancelBookButton.UseVisualStyleBackColor = true;
        // 
        // addReservationBookButton
        // 
        addReservationBookButton.Location = new Point(42, 375);
        addReservationBookButton.Name = "addReservationBookButton";
        addReservationBookButton.Size = new Size(110, 31);
        addReservationBookButton.TabIndex = 92;
        addReservationBookButton.Text = "Add book";
        addReservationBookButton.UseVisualStyleBackColor = true;
        addReservationBookButton.Click += addReservationBookButton_Click;
        // 
        // removeReservationBookButton
        // 
        removeReservationBookButton.Location = new Point(182, 375);
        removeReservationBookButton.Name = "removeReservationBookButton";
        removeReservationBookButton.Size = new Size(110, 31);
        removeReservationBookButton.TabIndex = 93;
        removeReservationBookButton.Text = "Remove book";
        removeReservationBookButton.UseVisualStyleBackColor = true;
        removeReservationBookButton.Click += removeReservationBookButton_Click;
        // 
        // ReservationDetailsForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        CancelButton = cancelBookButton;
        ClientSize = new Size(568, 448);
        Controls.Add(removeReservationBookButton);
        Controls.Add(addReservationBookButton);
        Controls.Add(cancelBookButton);
        Controls.Add(reservationDetailsDataGridView);
        Name = "ReservationDetailsForm";
        Text = "Reservation Details";
        ((System.ComponentModel.ISupportInitialize)reservationDetailsDataGridView).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private DataGridView reservationDetailsDataGridView;
    private Button cancelBookButton;
    private Button addReservationBookButton;
    private Button removeReservationBookButton;
}