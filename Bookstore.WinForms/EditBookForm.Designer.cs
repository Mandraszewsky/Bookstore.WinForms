namespace Bookstore.WinForms;

partial class EditBookForm
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
        bookAuthorLabel = new Label();
        bookAuthorComboBox = new ComboBox();
        cancelBookButton = new Button();
        updateBookButton = new Button();
        bookPublicationDateLabel = new Label();
        bookQuantityLabel = new Label();
        bookPageNumberLabel = new Label();
        bookDescriptionLabel = new Label();
        bookTitleLabel = new Label();
        bookISBNLabel = new Label();
        bookPublicationDateDateTimePicker = new DateTimePicker();
        bookQuantityTextBox = new TextBox();
        bookPageNumberTextBox = new TextBox();
        bookDescriptionTextBox = new TextBox();
        bookISBNTextBox = new TextBox();
        bookTitleTextBox = new TextBox();
        SuspendLayout();
        // 
        // bookAuthorLabel
        // 
        bookAuthorLabel.AutoSize = true;
        bookAuthorLabel.Location = new Point(78, 162);
        bookAuthorLabel.Name = "bookAuthorLabel";
        bookAuthorLabel.Size = new Size(53, 15);
        bookAuthorLabel.TabIndex = 31;
        bookAuthorLabel.Text = "Author : ";
        // 
        // bookAuthorComboBox
        // 
        bookAuthorComboBox.FormattingEnabled = true;
        bookAuthorComboBox.Location = new Point(136, 159);
        bookAuthorComboBox.Name = "bookAuthorComboBox";
        bookAuthorComboBox.Size = new Size(149, 23);
        bookAuthorComboBox.TabIndex = 30;
        // 
        // cancelBookButton
        // 
        cancelBookButton.Location = new Point(403, 372);
        cancelBookButton.Name = "cancelBookButton";
        cancelBookButton.Size = new Size(110, 31);
        cancelBookButton.TabIndex = 29;
        cancelBookButton.Text = "Cancel";
        cancelBookButton.UseVisualStyleBackColor = true;
        // 
        // updateBookButton
        // 
        updateBookButton.Location = new Point(264, 372);
        updateBookButton.Name = "updateBookButton";
        updateBookButton.Size = new Size(110, 31);
        updateBookButton.TabIndex = 28;
        updateBookButton.Text = "Update";
        updateBookButton.UseVisualStyleBackColor = true;
        updateBookButton.Click += updateBookButton_Click;
        // 
        // bookPublicationDateLabel
        // 
        bookPublicationDateLabel.AutoSize = true;
        bookPublicationDateLabel.Location = new Point(58, 203);
        bookPublicationDateLabel.Name = "bookPublicationDateLabel";
        bookPublicationDateLabel.Size = new Size(73, 15);
        bookPublicationDateLabel.TabIndex = 27;
        bookPublicationDateLabel.Text = "Publication :";
        // 
        // bookQuantityLabel
        // 
        bookQuantityLabel.AutoSize = true;
        bookQuantityLabel.Location = new Point(68, 283);
        bookQuantityLabel.Name = "bookQuantityLabel";
        bookQuantityLabel.Size = new Size(62, 15);
        bookQuantityLabel.TabIndex = 26;
        bookQuantityLabel.Text = "Quantity : ";
        // 
        // bookPageNumberLabel
        // 
        bookPageNumberLabel.AutoSize = true;
        bookPageNumberLabel.Location = new Point(46, 242);
        bookPageNumberLabel.Name = "bookPageNumberLabel";
        bookPageNumberLabel.Size = new Size(84, 15);
        bookPageNumberLabel.TabIndex = 25;
        bookPageNumberLabel.Text = "Page number :";
        // 
        // bookDescriptionLabel
        // 
        bookDescriptionLabel.AutoSize = true;
        bookDescriptionLabel.Location = new Point(57, 124);
        bookDescriptionLabel.Name = "bookDescriptionLabel";
        bookDescriptionLabel.Size = new Size(73, 15);
        bookDescriptionLabel.TabIndex = 24;
        bookDescriptionLabel.Text = "Description :";
        // 
        // bookTitleLabel
        // 
        bookTitleLabel.AutoSize = true;
        bookTitleLabel.Location = new Point(92, 84);
        bookTitleLabel.Name = "bookTitleLabel";
        bookTitleLabel.Size = new Size(35, 15);
        bookTitleLabel.TabIndex = 23;
        bookTitleLabel.Text = "Title :";
        // 
        // bookISBNLabel
        // 
        bookISBNLabel.AutoSize = true;
        bookISBNLabel.Location = new Point(92, 37);
        bookISBNLabel.Name = "bookISBNLabel";
        bookISBNLabel.Size = new Size(38, 15);
        bookISBNLabel.TabIndex = 22;
        bookISBNLabel.Text = "ISBN :";
        // 
        // bookPublicationDateDateTimePicker
        // 
        bookPublicationDateDateTimePicker.Location = new Point(136, 197);
        bookPublicationDateDateTimePicker.Name = "bookPublicationDateDateTimePicker";
        bookPublicationDateDateTimePicker.Size = new Size(149, 23);
        bookPublicationDateDateTimePicker.TabIndex = 21;
        // 
        // bookQuantityTextBox
        // 
        bookQuantityTextBox.Location = new Point(136, 280);
        bookQuantityTextBox.Name = "bookQuantityTextBox";
        bookQuantityTextBox.Size = new Size(78, 23);
        bookQuantityTextBox.TabIndex = 20;
        // 
        // bookPageNumberTextBox
        // 
        bookPageNumberTextBox.Location = new Point(136, 239);
        bookPageNumberTextBox.Name = "bookPageNumberTextBox";
        bookPageNumberTextBox.Size = new Size(78, 23);
        bookPageNumberTextBox.TabIndex = 19;
        // 
        // bookDescriptionTextBox
        // 
        bookDescriptionTextBox.Location = new Point(136, 121);
        bookDescriptionTextBox.Name = "bookDescriptionTextBox";
        bookDescriptionTextBox.Size = new Size(238, 23);
        bookDescriptionTextBox.TabIndex = 18;
        // 
        // bookISBNTextBox
        // 
        bookISBNTextBox.Location = new Point(136, 34);
        bookISBNTextBox.Name = "bookISBNTextBox";
        bookISBNTextBox.Size = new Size(238, 23);
        bookISBNTextBox.TabIndex = 17;
        // 
        // bookTitleTextBox
        // 
        bookTitleTextBox.Location = new Point(136, 81);
        bookTitleTextBox.Name = "bookTitleTextBox";
        bookTitleTextBox.Size = new Size(238, 23);
        bookTitleTextBox.TabIndex = 16;
        // 
        // EditBookForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(559, 434);
        Controls.Add(bookAuthorLabel);
        Controls.Add(bookAuthorComboBox);
        Controls.Add(cancelBookButton);
        Controls.Add(updateBookButton);
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
        Name = "EditBookForm";
        Text = "EditBookForm";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label bookAuthorLabel;
    private ComboBox bookAuthorComboBox;
    private Button cancelBookButton;
    private Button updateBookButton;
    private Label bookPublicationDateLabel;
    private Label bookQuantityLabel;
    private Label bookPageNumberLabel;
    private Label bookDescriptionLabel;
    private Label bookTitleLabel;
    private Label bookISBNLabel;
    private DateTimePicker bookPublicationDateDateTimePicker;
    private TextBox bookQuantityTextBox;
    private TextBox bookPageNumberTextBox;
    private TextBox bookDescriptionTextBox;
    private TextBox bookISBNTextBox;
    private TextBox bookTitleTextBox;
}