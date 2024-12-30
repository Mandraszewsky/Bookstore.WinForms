namespace Bookstore.WinForms.Forms.BookForms;

partial class BookForm
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
        removeBookButton = new Button();
        editBookButton = new Button();
        addBookButton = new Button();
        booksDataGridView = new DataGridView();
        ((System.ComponentModel.ISupportInitialize)booksDataGridView).BeginInit();
        SuspendLayout();
        // 
        // removeBookButton
        // 
        removeBookButton.Location = new Point(500, 492);
        removeBookButton.Name = "removeBookButton";
        removeBookButton.Size = new Size(141, 40);
        removeBookButton.TabIndex = 34;
        removeBookButton.Text = "Remove book";
        removeBookButton.UseVisualStyleBackColor = true;
        removeBookButton.Click += removeBookButton_Click;
        // 
        // editBookButton
        // 
        editBookButton.Location = new Point(323, 492);
        editBookButton.Name = "editBookButton";
        editBookButton.Size = new Size(141, 40);
        editBookButton.TabIndex = 33;
        editBookButton.Text = "Edit book";
        editBookButton.UseVisualStyleBackColor = true;
        editBookButton.Click += editBookButton_Click;
        // 
        // addBookButton
        // 
        addBookButton.Location = new Point(145, 492);
        addBookButton.Name = "addBookButton";
        addBookButton.Size = new Size(141, 40);
        addBookButton.TabIndex = 32;
        addBookButton.Text = "Add book";
        addBookButton.UseVisualStyleBackColor = true;
        addBookButton.Click += addBookButton_Click;
        // 
        // booksDataGridView
        // 
        booksDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        booksDataGridView.Location = new Point(145, 26);
        booksDataGridView.Name = "booksDataGridView";
        booksDataGridView.Size = new Size(718, 436);
        booksDataGridView.TabIndex = 31;
        // 
        // BookForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(909, 549);
        Controls.Add(removeBookButton);
        Controls.Add(editBookButton);
        Controls.Add(addBookButton);
        Controls.Add(booksDataGridView);
        Name = "BookForm";
        Text = "BookForm";
        Activated += BooksForm_Activated;
        Enter += BooksForm_Activated;
        ((System.ComponentModel.ISupportInitialize)booksDataGridView).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private Button removeBookButton;
    private Button editBookButton;
    private Button addBookButton;
    private DataGridView booksDataGridView;
}