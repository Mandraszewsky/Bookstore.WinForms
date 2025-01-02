using Bookstore.DomainLayer.Models;

namespace Bookstore.ApplicationLayer.Interfaces.AuthorInterfaces;

public interface IAuthorRepository
{
    Task<List<Author>> GetAuthorList();
}
