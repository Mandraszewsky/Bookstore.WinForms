namespace Bookstore.WinForms.Forms.ReservationForms;

partial class AddReservationForm
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
        reservationCustomerLabel = new Label();
        reservationCustomerComboBox = new ComboBox();
        cancelReservationButton = new Button();
        addReservationButton = new Button();
        reservationDateLabel = new Label();
        reservationDateDateTimePicker = new DateTimePicker();
        reservationStatusLabel = new Label();
        reservationStatusComboBox = new ComboBox();
        SuspendLayout();
        // 
        // reservationCustomerLabel
        // 
        reservationCustomerLabel.AutoSize = true;
        reservationCustomerLabel.Location = new Point(70, 42);
        reservationCustomerLabel.Name = "reservationCustomerLabel";
        reservationCustomerLabel.Size = new Size(68, 15);
        reservationCustomerLabel.TabIndex = 93;
        reservationCustomerLabel.Text = "Customer : ";
        // 
        // reservationCustomerComboBox
        // 
        reservationCustomerComboBox.FormattingEnabled = true;
        reservationCustomerComboBox.Location = new Point(142, 39);
        reservationCustomerComboBox.Name = "reservationCustomerComboBox";
        reservationCustomerComboBox.Size = new Size(149, 23);
        reservationCustomerComboBox.TabIndex = 95;
        // 
        // cancelReservationButton
        // 
        cancelReservationButton.Location = new Point(286, 210);
        cancelReservationButton.Name = "cancelReservationButton";
        cancelReservationButton.Size = new Size(110, 31);
        cancelReservationButton.TabIndex = 98;
        cancelReservationButton.Text = "Cancel";
        cancelReservationButton.UseVisualStyleBackColor = true;
        // 
        // addReservationButton
        // 
        addReservationButton.Location = new Point(142, 210);
        addReservationButton.Name = "addReservationButton";
        addReservationButton.Size = new Size(110, 31);
        addReservationButton.TabIndex = 97;
        addReservationButton.Text = "Add";
        addReservationButton.UseVisualStyleBackColor = true;
        addReservationButton.Click += addReservationButton_Click;
        // 
        // reservationDateLabel
        // 
        reservationDateLabel.AutoSize = true;
        reservationDateLabel.Location = new Point(64, 134);
        reservationDateLabel.Name = "reservationDateLabel";
        reservationDateLabel.Size = new Size(74, 15);
        reservationDateLabel.TabIndex = 92;
        reservationDateLabel.Text = "Reservation :";
        // 
        // reservationDateDateTimePicker
        // 
        reservationDateDateTimePicker.Location = new Point(142, 128);
        reservationDateDateTimePicker.Name = "reservationDateDateTimePicker";
        reservationDateDateTimePicker.Size = new Size(149, 23);
        reservationDateDateTimePicker.TabIndex = 96;
        // 
        // reservationStatusLabel
        // 
        reservationStatusLabel.AutoSize = true;
        reservationStatusLabel.Location = new Point(91, 88);
        reservationStatusLabel.Name = "reservationStatusLabel";
        reservationStatusLabel.Size = new Size(45, 15);
        reservationStatusLabel.TabIndex = 99;
        reservationStatusLabel.Text = "Status :";
        // 
        // reservationStatusComboBox
        // 
        reservationStatusComboBox.FormattingEnabled = true;
        reservationStatusComboBox.Location = new Point(142, 85);
        reservationStatusComboBox.Name = "reservationStatusComboBox";
        reservationStatusComboBox.Size = new Size(149, 23);
        reservationStatusComboBox.TabIndex = 100;
        // 
        // AddReservationForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(421, 259);
        Controls.Add(reservationStatusLabel);
        Controls.Add(reservationStatusComboBox);
        Controls.Add(reservationCustomerLabel);
        Controls.Add(reservationCustomerComboBox);
        Controls.Add(cancelReservationButton);
        Controls.Add(addReservationButton);
        Controls.Add(reservationDateLabel);
        Controls.Add(reservationDateDateTimePicker);
        Name = "AddReservationForm";
        Text = "Add Reservation";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label reservationCustomerLabel;
    private ComboBox reservationCustomerComboBox;
    private Button cancelReservationButton;
    private Button addReservationButton;
    private Label reservationDateLabel;
    private DateTimePicker reservationDateDateTimePicker;
    private Label reservationStatusLabel;
    private ComboBox reservationStatusComboBox;
}