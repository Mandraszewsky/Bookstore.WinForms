﻿using Bookstore.DomainLayer.Models;

namespace Bookstore.ApplicationLayer.Interfaces.AuthorInterfaces;

public interface IAuthorService
{
    Task<List<Author>> GetAuthorList();
}
