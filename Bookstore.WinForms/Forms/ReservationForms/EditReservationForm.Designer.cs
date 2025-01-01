namespace Bookstore.WinForms.Forms.ReservationForms;

partial class EditReservationForm
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
        reservationStatusLabel = new Label();
        reservationStatusComboBox = new ComboBox();
        cancelReservationButton = new Button();
        updateReservationButton = new Button();
        reservationDateLabel = new Label();
        reservationDateDateTimePicker = new DateTimePicker();
        SuspendLayout();
        // 
        // reservationStatusLabel
        // 
        reservationStatusLabel.AutoSize = true;
        reservationStatusLabel.Location = new Point(102, 41);
        reservationStatusLabel.Name = "reservationStatusLabel";
        reservationStatusLabel.Size = new Size(42, 15);
        reservationStatusLabel.TabIndex = 92;
        reservationStatusLabel.Text = "Status:";
        // 
        // reservationStatusComboBox
        // 
        reservationStatusComboBox.FormattingEnabled = true;
        reservationStatusComboBox.Location = new Point(150, 38);
        reservationStatusComboBox.Name = "reservationStatusComboBox";
        reservationStatusComboBox.Size = new Size(149, 23);
        reservationStatusComboBox.TabIndex = 93;
        // 
        // cancelReservationButton
        // 
        cancelReservationButton.Location = new Point(326, 148);
        cancelReservationButton.Name = "cancelReservationButton";
        cancelReservationButton.Size = new Size(110, 31);
        cancelReservationButton.TabIndex = 96;
        cancelReservationButton.Text = "Cancel";
        cancelReservationButton.UseVisualStyleBackColor = true;
        // 
        // updateReservationButton
        // 
        updateReservationButton.Location = new Point(187, 148);
        updateReservationButton.Name = "updateReservationButton";
        updateReservationButton.Size = new Size(110, 31);
        updateReservationButton.TabIndex = 95;
        updateReservationButton.Text = "Update";
        updateReservationButton.UseVisualStyleBackColor = true;
        updateReservationButton.Click += updateReservationButton_Click;
        // 
        // reservationDateLabel
        // 
        reservationDateLabel.AutoSize = true;
        reservationDateLabel.Location = new Point(107, 82);
        reservationDateLabel.Name = "reservationDateLabel";
        reservationDateLabel.Size = new Size(37, 15);
        reservationDateLabel.TabIndex = 91;
        reservationDateLabel.Text = "Date :";
        // 
        // reservationDateDateTimePicker
        // 
        reservationDateDateTimePicker.Format = DateTimePickerFormat.Short;
        reservationDateDateTimePicker.Location = new Point(150, 76);
        reservationDateDateTimePicker.Name = "reservationDateDateTimePicker";
        reservationDateDateTimePicker.Size = new Size(149, 23);
        reservationDateDateTimePicker.TabIndex = 94;
        // 
        // EditReservationForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        CancelButton = cancelReservationButton;
        ClientSize = new Size(462, 203);
        Controls.Add(reservationStatusLabel);
        Controls.Add(reservationStatusComboBox);
        Controls.Add(cancelReservationButton);
        Controls.Add(updateReservationButton);
        Controls.Add(reservationDateLabel);
        Controls.Add(reservationDateDateTimePicker);
        Name = "EditReservationForm";
        Text = "Edit Reservation";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label reservationStatusLabel;
    private ComboBox reservationStatusComboBox;
    private Button cancelReservationButton;
    private Button updateReservationButton;
    private Label reservationDateLabel;
    private DateTimePicker reservationDateDateTimePicker;
}