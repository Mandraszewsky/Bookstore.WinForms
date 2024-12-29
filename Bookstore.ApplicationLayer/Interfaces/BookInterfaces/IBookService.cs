﻿using Bookstore.Domain.Models;

namespace Bookstore.ApplicationLayer.Interfaces.BookInterfaces;

public interface IBookService
{
    List<Book> GetBooksAsync();
    Task CreateBook(Book book);
}

