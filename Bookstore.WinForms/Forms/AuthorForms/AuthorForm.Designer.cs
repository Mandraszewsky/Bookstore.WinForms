namespace Bookstore.WinForms.Forms.AuthorForms;

partial class AuthorForm
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
        authorsDataGridView = new DataGridView();
        ((System.ComponentModel.ISupportInitialize)authorsDataGridView).BeginInit();
        SuspendLayout();
        // 
        // authorsDataGridView
        // 
        authorsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        authorsDataGridView.Location = new Point(95, 21);
        authorsDataGridView.Name = "authorsDataGridView";
        authorsDataGridView.Size = new Size(718, 436);
        authorsDataGridView.TabIndex = 36;
        // 
        // AuthorForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(909, 549);
        Controls.Add(authorsDataGridView);
        Name = "AuthorForm";
        Text = "AuthorForm";
        ((System.ComponentModel.ISupportInitialize)authorsDataGridView).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private DataGridView authorsDataGridView;
}