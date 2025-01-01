namespace Bookstore.WinForms;

partial class AddBookForm
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
        bookTitleTextBox = new TextBox();
        bookISBNTextBox = new TextBox();
        bookDescriptionTextBox = new TextBox();
        bookPageNumberTextBox = new TextBox();
        bookQuantityTextBox = new TextBox();
        bookPublicationDateDateTimePicker = new DateTimePicker();
        bookISBNLabel = new Label();
        bookTitleLabel = new Label();
        bookDescriptionLabel = new Label();
        bookPageNumberLabel = new Label();
        bookQuantityLabel = new Label();
        bookPublicationDateLabel = new Label();
        addBookButton = new Button();
        cancelBookButton = new Button();
        bookAuthorComboBox = new ComboBox();
        bookAuthorLabel = new Label();
        SuspendLayout();
        // 
        // bookTitleTextBox
        // 
        bookTitleTextBox.Location = new Point(155, 99);
        bookTitleTextBox.Name = "bookTitleTextBox";
        bookTitleTextBox.Size = new Size(238, 23);
        bookTitleTextBox.TabIndex = 20;
        // 
        // bookISBNTextBox
        // 
        bookISBNTextBox.Location = new Point(155, 52);
        bookISBNTextBox.Name = "bookISBNTextBox";
        bookISBNTextBox.Size = new Size(238, 23);
        bookISBNTextBox.TabIndex = 10;
        // 
        // bookDescriptionTextBox
        // 
        bookDescriptionTextBox.Location = new Point(155, 139);
        bookDescriptionTextBox.Name = "bookDescriptionTextBox";
        bookDescriptionTextBox.Size = new Size(238, 23);
        bookDescriptionTextBox.TabIndex = 30;
        // 
        // bookPageNumberTextBox
        // 
        bookPageNumberTextBox.Location = new Point(155, 257);
        bookPageNumberTextBox.Name = "bookPageNumberTextBox";
        bookPageNumberTextBox.Size = new Size(78, 23);
        bookPageNumberTextBox.TabIndex = 60;
        // 
        // bookQuantityTextBox
        // 
        bookQuantityTextBox.Location = new Point(155, 298);
        bookQuantityTextBox.Name = "bookQuantityTextBox";
        bookQuantityTextBox.Size = new Size(78, 23);
        bookQuantityTextBox.TabIndex = 70;
        // 
        // bookPublicationDateDateTimePicker
        // 
        bookPublicationDateDateTimePicker.Format = DateTimePickerFormat.Short;
        bookPublicationDateDateTimePicker.Location = new Point(155, 215);
        bookPublicationDateDateTimePicker.Name = "bookPublicationDateDateTimePicker";
        bookPublicationDateDateTimePicker.Size = new Size(149, 23);
        bookPublicationDateDateTimePicker.TabIndex = 50;
        // 
        // bookISBNLabel
        // 
        bookISBNLabel.AutoSize = true;
        bookISBNLabel.Location = new Point(111, 55);
        bookISBNLabel.Name = "bookISBNLabel";
        bookISBNLabel.Size = new Size(38, 15);
        bookISBNLabel.TabIndex = 6;
        bookISBNLabel.Text = "ISBN :";
        // 
        // bookTitleLabel
        // 
        bookTitleLabel.AutoSize = true;
        bookTitleLabel.Location = new Point(111, 102);
        bookTitleLabel.Name = "bookTitleLabel";
        bookTitleLabel.Size = new Size(35, 15);
        bookTitleLabel.TabIndex = 7;
        bookTitleLabel.Text = "Title :";
        // 
        // bookDescriptionLabel
        // 
        bookDescriptionLabel.AutoSize = true;
        bookDescriptionLabel.Location = new Point(76, 142);
        bookDescriptionLabel.Name = "bookDescriptionLabel";
        bookDescriptionLabel.Size = new Size(73, 15);
        bookDescriptionLabel.TabIndex = 8;
        bookDescriptionLabel.Text = "Description :";
        // 
        // bookPageNumberLabel
        // 
        bookPageNumberLabel.AutoSize = true;
        bookPageNumberLabel.Location = new Point(65, 260);
        bookPageNumberLabel.Name = "bookPageNumberLabel";
        bookPageNumberLabel.Size = new Size(84, 15);
        bookPageNumberLabel.TabIndex = 9;
        bookPageNumberLabel.Text = "Page number :";
        // 
        // bookQuantityLabel
        // 
        bookQuantityLabel.AutoSize = true;
        bookQuantityLabel.Location = new Point(87, 301);
        bookQuantityLabel.Name = "bookQuantityLabel";
        bookQuantityLabel.Size = new Size(62, 15);
        bookQuantityLabel.TabIndex = 10;
        bookQuantityLabel.Text = "Quantity : ";
        // 
        // bookPublicationDateLabel
        // 
        bookPublicationDateLabel.AutoSize = true;
        bookPublicationDateLabel.Location = new Point(77, 221);
        bookPublicationDateLabel.Name = "bookPublicationDateLabel";
        bookPublicationDateLabel.Size = new Size(73, 15);
        bookPublicationDateLabel.TabIndex = 11;
        bookPublicationDateLabel.Text = "Publication :";
        // 
        // addBookButton
        // 
        addBookButton.Location = new Point(283, 390);
        addBookButton.Name = "addBookButton";
        addBookButton.Size = new Size(110, 31);
        addBookButton.TabIndex = 80;
        addBookButton.Text = "Add";
        addBookButton.UseVisualStyleBackColor = true;
        addBookButton.Click += addBookButton_Click;
        // 
        // cancelBookButton
        // 
        cancelBookButton.Location = new Point(422, 390);
        cancelBookButton.Name = "cancelBookButton";
        cancelBookButton.Size = new Size(110, 31);
        cancelBookButton.TabIndex = 90;
        cancelBookButton.Text = "Cancel";
        cancelBookButton.UseVisualStyleBackColor = true;
        // 
        // bookAuthorComboBox
        // 
        bookAuthorComboBox.FormattingEnabled = true;
        bookAuthorComboBox.Location = new Point(155, 177);
        bookAuthorComboBox.Name = "bookAuthorComboBox";
        bookAuthorComboBox.Size = new Size(149, 23);
        bookAuthorComboBox.TabIndex = 40;
        // 
        // bookAuthorLabel
        // 
        bookAuthorLabel.AutoSize = true;
        bookAuthorLabel.Location = new Point(97, 180);
        bookAuthorLabel.Name = "bookAuthorLabel";
        bookAuthorLabel.Size = new Size(53, 15);
        bookAuthorLabel.TabIndex = 15;
        bookAuthorLabel.Text = "Author : ";
        // 
        // AddBookForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        CancelButton = cancelBookButton;
        ClientSize = new Size(568, 448);
        Controls.Add(bookAuthorLabel);
        Controls.Add(bookAuthorComboBox);
        Controls.Add(cancelBookButton);
        Controls.Add(addBookButton);
        Controls.Add(bookPublicationDateLabel);
        Controls.Add(bookQuantityLabel);
        Controls.Add(bookPageNumberLabel);
        Controls.Add(bookDescriptionLabel);
        Controls.Add(bookTitleLabel);
        Controls.Add(bookISBNLabel);
        Controls.Add(bookPublicationDateDateTimePicker);
        Controls.Add(bookQuantityTextBox);
        Controls.Add(bookPageNumberTextBox);
        Controls.Add(bookDescriptionTextBox);
        Controls.Add(bookISBNTextBox);
        Controls.Add(bookTitleTextBox);
        MinimizeBox = false;
        Name = "AddBookForm";
        Text = "Add Book";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox bookTitleTextBox;
    private TextBox bookISBNTextBox;
    private TextBox bookDescriptionTextBox;
    private TextBox bookPageNumberTextBox;
    private TextBox bookQuantityTextBox;
    private DateTimePicker bookPublicationDateDateTimePicker;
    private Label bookISBNLabel;
    private Label bookTitleLabel;
    private Label bookDescriptionLabel;
    private Label bookPageNumberLabel;
    private Label bookQuantityLabel;
    private Label bookPublicationDateLabel;
    private Button addBookButton;
    private Button cancelBookButton;
    private ComboBox bookAuthorComboBox;
    private Label bookAuthorLabel;
}