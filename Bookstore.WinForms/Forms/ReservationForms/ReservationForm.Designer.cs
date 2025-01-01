namespace Bookstore.WinForms.Forms.ReservationForms;

partial class ReservationForm
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
        editReservationButton = new Button();
        addReservationButton = new Button();
        reservationsDataGridView = new DataGridView();
        reservationDetailsButton = new Button();
        ((System.ComponentModel.ISupportInitialize)reservationsDataGridView).BeginInit();
        SuspendLayout();
        // 
        // editReservationButton
        // 
        editReservationButton.Location = new Point(273, 487);
        editReservationButton.Name = "editReservationButton";
        editReservationButton.Size = new Size(141, 40);
        editReservationButton.TabIndex = 37;
        editReservationButton.Text = "Edit reservation";
        editReservationButton.UseVisualStyleBackColor = true;
        editReservationButton.Click += editReservationButton_Click;
        // 
        // addReservationButton
        // 
        addReservationButton.Location = new Point(95, 487);
        addReservationButton.Name = "addReservationButton";
        addReservationButton.Size = new Size(141, 40);
        addReservationButton.TabIndex = 36;
        addReservationButton.Text = "Add reservation";
        addReservationButton.UseVisualStyleBackColor = true;
        addReservationButton.Click += addReservationButton_Click;
        // 
        // reservationsDataGridView
        // 
        reservationsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        reservationsDataGridView.Location = new Point(95, 21);
        reservationsDataGridView.Name = "reservationsDataGridView";
        reservationsDataGridView.Size = new Size(718, 436);
        reservationsDataGridView.TabIndex = 35;
        // 
        // reservationDetailsButton
        // 
        reservationDetailsButton.Location = new Point(672, 487);
        reservationDetailsButton.Name = "reservationDetailsButton";
        reservationDetailsButton.Size = new Size(141, 40);
        reservationDetailsButton.TabIndex = 39;
        reservationDetailsButton.Text = "Show details";
        reservationDetailsButton.UseVisualStyleBackColor = true;
        reservationDetailsButton.Click += reservationDetailsButton_Click;
        // 
        // ReservationForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(909, 549);
        Controls.Add(reservationDetailsButton);
        Controls.Add(editReservationButton);
        Controls.Add(addReservationButton);
        Controls.Add(reservationsDataGridView);
        Name = "ReservationForm";
        Text = "ReservationForm";
        ((System.ComponentModel.ISupportInitialize)reservationsDataGridView).EndInit();
        ResumeLayout(false);
    }

    #endregion
    private Button editReservationButton;
    private Button addReservationButton;
    private DataGridView reservationsDataGridView;
    private Button reservationDetailsButton;
}