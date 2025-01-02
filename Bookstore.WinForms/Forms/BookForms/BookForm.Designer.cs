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
        bookSearchNameTextBox = new TextBox();
        bookSearchISBNTextBox = new TextBox();
        bookSearchNameLabel = new Label();
        label1 = new Label();
        bookSearchFromDateTimePicker = new DateTimePicker();
        bookSearchToDateTimePicker = new DateTimePicker();
        bookSearchFromLabel = new Label();
        bookSearchToLabel = new Label();
        resetBookFilterButton = new Button();
        applayDateBookFilterButton = new Button();
        ((System.ComponentModel.ISupportInitialize)booksDataGridView).BeginInit();
        SuspendLayout();
        // 
        // removeBookButton
        // 
        removeBookButton.Location = new Point(450, 487);
        removeBookButton.Name = "removeBookButton";
        removeBookButton.Size = new Size(141, 40);
        removeBookButton.TabIndex = 34;
        removeBookButton.Text = "Remove book";
        removeBookButton.UseVisualStyleBackColor = true;
        removeBookButton.Click += removeBookButton_Click;
        // 
        // editBookButton
        // 
        editBookButton.Location = new Point(273, 487);
        editBookButton.Name = "editBookButton";
        editBookButton.Size = new Size(141, 40);
        editBookButton.TabIndex = 33;
        editBookButton.Text = "Edit book";
        editBookButton.UseVisualStyleBackColor = true;
        editBookButton.Click += editBookButton_Click;
        // 
        // addBookButton
        // 
        addBookButton.Location = new Point(95, 487);
        addBookButton.Name = "addBookButton";
        addBookButton.Size = new Size(141, 40);
        addBookButton.TabIndex = 32;
        addBookButton.Text = "Add book";
        addBookButton.UseVisualStyleBackColor = true;
        addBookButton.Click += addBookButton_Click;
        // 
        // booksDataGridView
        // 
        booksDataGridView.AllowUserToAddRows = false;
        booksDataGridView.AllowUserToDeleteRows = false;
        booksDataGridView.AllowUserToOrderColumns = true;
        booksDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        booksDataGridView.Location = new Point(95, 115);
        booksDataGridView.Name = "booksDataGridView";
        booksDataGridView.ReadOnly = true;
        booksDataGridView.Size = new Size(718, 342);
        booksDataGridView.TabIndex = 31;
        // 
        // bookSearchNameTextBox
        // 
        bookSearchNameTextBox.Location = new Point(95, 27);
        bookSearchNameTextBox.Name = "bookSearchNameTextBox";
        bookSearchNameTextBox.Size = new Size(280, 23);
        bookSearchNameTextBox.TabIndex = 35;
        bookSearchNameTextBox.TextChanged += bookFilterTextBox_TextChanged;
        // 
        // bookSearchISBNTextBox
        // 
        bookSearchISBNTextBox.Location = new Point(398, 27);
        bookSearchISBNTextBox.Name = "bookSearchISBNTextBox";
        bookSearchISBNTextBox.Size = new Size(280, 23);
        bookSearchISBNTextBox.TabIndex = 36;
        bookSearchISBNTextBox.TextChanged += bookFilterTextBox_TextChanged;
        // 
        // bookSearchNameLabel
        // 
        bookSearchNameLabel.AutoSize = true;
        bookSearchNameLabel.Location = new Point(95, 9);
        bookSearchNameLabel.Name = "bookSearchNameLabel";
        bookSearchNameLabel.Size = new Size(84, 15);
        bookSearchNameLabel.TabIndex = 37;
        bookSearchNameLabel.Text = "Search by title:";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(398, 9);
        label1.Name = "label1";
        label1.Size = new Size(89, 15);
        label1.TabIndex = 38;
        label1.Text = "Search by ISBN:";
        // 
        // bookSearchFromDateTimePicker
        // 
        bookSearchFromDateTimePicker.Format = DateTimePickerFormat.Short;
        bookSearchFromDateTimePicker.Location = new Point(95, 77);
        bookSearchFromDateTimePicker.Name = "bookSearchFromDateTimePicker";
        bookSearchFromDateTimePicker.Size = new Size(149, 23);
        bookSearchFromDateTimePicker.TabIndex = 97;
        bookSearchFromDateTimePicker.Value = new DateTime(2025, 1, 1, 0, 0, 0, 0);
        // 
        // bookSearchToDateTimePicker
        // 
        bookSearchToDateTimePicker.Format = DateTimePickerFormat.Short;
        bookSearchToDateTimePicker.Location = new Point(273, 77);
        bookSearchToDateTimePicker.Name = "bookSearchToDateTimePicker";
        bookSearchToDateTimePicker.Size = new Size(149, 23);
        bookSearchToDateTimePicker.TabIndex = 98;
        // 
        // bookSearchFromLabel
        // 
        bookSearchFromLabel.AutoSize = true;
        bookSearchFromLabel.Location = new Point(95, 59);
        bookSearchFromLabel.Name = "bookSearchFromLabel";
        bookSearchFromLabel.Size = new Size(66, 15);
        bookSearchFromLabel.TabIndex = 99;
        bookSearchFromLabel.Text = "Date from :";
        // 
        // bookSearchToLabel
        // 
        bookSearchToLabel.AutoSize = true;
        bookSearchToLabel.Location = new Point(273, 59);
        bookSearchToLabel.Name = "bookSearchToLabel";
        bookSearchToLabel.Size = new Size(51, 15);
        bookSearchToLabel.TabIndex = 100;
        bookSearchToLabel.Text = "Date to :";
        // 
        // resetBookFilterButton
        // 
        resetBookFilterButton.Location = new Point(564, 71);
        resetBookFilterButton.Name = "resetBookFilterButton";
        resetBookFilterButton.Size = new Size(114, 29);
        resetBookFilterButton.TabIndex = 101;
        resetBookFilterButton.Text = "Reset filters";
        resetBookFilterButton.UseVisualStyleBackColor = true;
        resetBookFilterButton.Click += resetBookFilterButton_Click;
        // 
        // applayDateBookFilterButton
        // 
        applayDateBookFilterButton.Location = new Point(444, 71);
        applayDateBookFilterButton.Name = "applayDateBookFilterButton";
        applayDateBookFilterButton.Size = new Size(114, 29);
        applayDateBookFilterButton.TabIndex = 102;
        applayDateBookFilterButton.Text = "Applay date";
        applayDateBookFilterButton.UseVisualStyleBackColor = true;
        applayDateBookFilterButton.Click += applayDateBookFilterButton_Click;
        // 
        // BookForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(909, 549);
        Controls.Add(applayDateBookFilterButton);
        Controls.Add(resetBookFilterButton);
        Controls.Add(bookSearchToLabel);
        Controls.Add(bookSearchFromLabel);
        Controls.Add(bookSearchToDateTimePicker);
        Controls.Add(bookSearchFromDateTimePicker);
        Controls.Add(label1);
        Controls.Add(bookSearchNameLabel);
        Controls.Add(bookSearchISBNTextBox);
        Controls.Add(bookSearchNameTextBox);
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
        PerformLayout();
    }

    #endregion

    private Button removeBookButton;
    private Button editBookButton;
    private Button addBookButton;
    private DataGridView booksDataGridView;
    private TextBox bookSearchNameTextBox;
    private TextBox bookSearchISBNTextBox;
    private Label bookSearchNameLabel;
    private Label label1;
    private DateTimePicker bookSearchFromDateTimePicker;
    private DateTimePicker bookSearchToDateTimePicker;
    private Label bookSearchFromLabel;
    private Label bookSearchToLabel;
    private Button resetBookFilterButton;
    private Button applayDateBookFilterButton;
}