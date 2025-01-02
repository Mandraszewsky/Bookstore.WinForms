﻿using Bookstore.DomainLayer.Models;

namespace Bookstore.ApplicationLayer.Interfaces.BookInterfaces;

public interface IBookService
{
    Task<List<Book>> GetBooksAsync();
    Task<Book> GetBookById(Guid id);
    Task CreateBook(Book book);
    Task UpdateBook(Book book);
    Task DeleteBook(Guid id);
}

