namespace Bookstore.WinForms;

partial class MainForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
        sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
        navigationPanel = new Panel();
        cutomersButton = new Button();
        authorsButton = new Button();
        reservationsButton = new Button();
        booksButton = new Button();
        currentViewPanel = new Panel();
        navigationPanel.SuspendLayout();
        SuspendLayout();
        // 
        // navigationPanel
        // 
        navigationPanel.BackColor = Color.FromArgb(64, 0, 64);
        navigationPanel.Controls.Add(cutomersButton);
        navigationPanel.Controls.Add(authorsButton);
        navigationPanel.Controls.Add(reservationsButton);
        navigationPanel.Controls.Add(booksButton);
        navigationPanel.Dock = DockStyle.Left;
        navigationPanel.Location = new Point(0, 0);
        navigationPanel.Name = "navigationPanel";
        navigationPanel.Size = new Size(251, 611);
        navigationPanel.TabIndex = 31;
        // 
        // cutomersButton
        // 
        cutomersButton.BackColor = Color.FromArgb(64, 0, 64);
        cutomersButton.Dock = DockStyle.Top;
        cutomersButton.FlatAppearance.BorderSize = 0;
        cutomersButton.FlatStyle = FlatStyle.Flat;
        cutomersButton.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        cutomersButton.ForeColor = SystemColors.Control;
        cutomersButton.Image = (Image)resources.GetObject("cutomersButton.Image");
        cutomersButton.ImageAlign = ContentAlignment.TopLeft;
        cutomersButton.Location = new Point(0, 201);
        cutomersButton.Name = "cutomersButton";
        cutomersButton.Size = new Size(251, 67);
        cutomersButton.TabIndex = 3;
        cutomersButton.Text = "Customers";
        cutomersButton.UseVisualStyleBackColor = false;
        cutomersButton.Click += cutomersButton_Click;
        // 
        // authorsButton
        // 
        authorsButton.BackColor = Color.FromArgb(64, 0, 64);
        authorsButton.Dock = DockStyle.Top;
        authorsButton.FlatAppearance.BorderSize = 0;
        authorsButton.FlatStyle = FlatStyle.Flat;
        authorsButton.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        authorsButton.ForeColor = SystemColors.Control;
        authorsButton.Image = (Image)resources.GetObject("authorsButton.Image");
        authorsButton.ImageAlign = ContentAlignment.TopLeft;
        authorsButton.Location = new Point(0, 134);
        authorsButton.Name = "authorsButton";
        authorsButton.Size = new Size(251, 67);
        authorsButton.TabIndex = 2;
        authorsButton.Text = "Authors";
        authorsButton.UseVisualStyleBackColor = false;
        authorsButton.Click += authorsButton_Click;
        // 
        // reservationsButton
        // 
        reservationsButton.BackColor = Color.FromArgb(64, 0, 64);
        reservationsButton.Dock = DockStyle.Top;
        reservationsButton.FlatAppearance.BorderSize = 0;
        reservationsButton.FlatStyle = FlatStyle.Flat;
        reservationsButton.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        reservationsButton.ForeColor = SystemColors.Control;
        reservationsButton.Image = (Image)resources.GetObject("reservationsButton.Image");
        reservationsButton.ImageAlign = ContentAlignment.TopLeft;
        reservationsButton.Location = new Point(0, 67);
        reservationsButton.Name = "reservationsButton";
        reservationsButton.Size = new Size(251, 67);
        reservationsButton.TabIndex = 1;
        reservationsButton.Text = "Reservations";
        reservationsButton.UseVisualStyleBackColor = false;
        reservationsButton.Click += reservationsButton_Click;
        // 
        // booksButton
        // 
        booksButton.BackColor = Color.FromArgb(64, 0, 64);
        booksButton.Dock = DockStyle.Top;
        booksButton.FlatAppearance.BorderSize = 0;
        booksButton.FlatStyle = FlatStyle.Flat;
        booksButton.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        booksButton.ForeColor = SystemColors.Control;
        booksButton.Image = Properties.Resources.book1;
        booksButton.ImageAlign = ContentAlignment.TopLeft;
        booksButton.Location = new Point(0, 0);
        booksButton.Name = "booksButton";
        booksButton.Size = new Size(251, 67);
        booksButton.TabIndex = 0;
        booksButton.Text = "Books";
        booksButton.UseVisualStyleBackColor = false;
        booksButton.Click += booksButton_Click;
        // 
        // currentViewPanel
        // 
        currentViewPanel.Dock = DockStyle.Fill;
        currentViewPanel.Location = new Point(251, 0);
        currentViewPanel.Name = "currentViewPanel";
        currentViewPanel.Size = new Size(933, 611);
        currentViewPanel.TabIndex = 32;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1184, 611);
        Controls.Add(currentViewPanel);
        Controls.Add(navigationPanel);
        MaximizeBox = false;
        Name = "MainForm";
        Text = "Bookstore";
        navigationPanel.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion
    private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
    private Panel navigationPanel;
    private Button booksButton;
    private Button cutomersButton;
    private Button authorsButton;
    private Button reservationsButton;
    private Panel currentViewPanel;
}
