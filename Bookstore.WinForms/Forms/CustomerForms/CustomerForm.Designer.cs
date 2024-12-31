namespace Bookstore.WinForms.Forms.CustomerForms;

partial class CustomerForm
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
        customersDataGridView = new DataGridView();
        ((System.ComponentModel.ISupportInitialize)customersDataGridView).BeginInit();
        SuspendLayout();
        // 
        // customersDataGridView
        // 
        customersDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        customersDataGridView.Location = new Point(95, 21);
        customersDataGridView.Name = "customersDataGridView";
        customersDataGridView.Size = new Size(718, 436);
        customersDataGridView.TabIndex = 36;
        // 
        // CustomerForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(909, 549);
        Controls.Add(customersDataGridView);
        Name = "CustomerForm";
        Text = "CustomerForm";
        ((System.ComponentModel.ISupportInitialize)customersDataGridView).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private DataGridView customersDataGridView;
}