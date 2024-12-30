﻿namespace Bookstore.WinForms;

partial class BooksForm
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
        booksDataGridView = new DataGridView();
        addBookButton = new Button();
        sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
        editBookButton = new Button();
        removeBookButton = new Button();
        ((System.ComponentModel.ISupportInitialize)booksDataGridView).BeginInit();
        SuspendLayout();
        // 
        // booksDataGridView
        // 
        booksDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        booksDataGridView.Location = new Point(393, 62);
        booksDataGridView.Name = "booksDataGridView";
        booksDataGridView.Size = new Size(718, 436);
        booksDataGridView.TabIndex = 0;
        // 
        // addBookButton
        // 
        addBookButton.Location = new Point(393, 528);
        addBookButton.Name = "addBookButton";
        addBookButton.Size = new Size(141, 40);
        addBookButton.TabIndex = 10;
        addBookButton.Text = "Add book";
        addBookButton.UseVisualStyleBackColor = true;
        addBookButton.Click += addBookButton_Click;
        // 
        // editBookButton
        // 
        editBookButton.Location = new Point(571, 528);
        editBookButton.Name = "editBookButton";
        editBookButton.Size = new Size(141, 40);
        editBookButton.TabIndex = 20;
        editBookButton.Text = "Edit book";
        editBookButton.UseVisualStyleBackColor = true;
        editBookButton.Click += editBookButton_Click;
        // 
        // removeBookButton
        // 
        removeBookButton.Location = new Point(748, 528);
        removeBookButton.Name = "removeBookButton";
        removeBookButton.Size = new Size(141, 40);
        removeBookButton.TabIndex = 30;
        removeBookButton.Text = "Remove book";
        removeBookButton.UseVisualStyleBackColor = true;
        removeBookButton.Click += removeBookButton_Click;
        // 
        // BooksForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1230, 711);
        Controls.Add(removeBookButton);
        Controls.Add(editBookButton);
        Controls.Add(addBookButton);
        Controls.Add(booksDataGridView);
        MaximizeBox = false;
        Name = "BooksForm";
        Text = "Bookstore";
        Activated += BooksForm_Activated;
        ((System.ComponentModel.ISupportInitialize)booksDataGridView).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private DataGridView booksDataGridView;
    private Button addBookButton;
    private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
    private Button editBookButton;
    private Button removeBookButton;
}
