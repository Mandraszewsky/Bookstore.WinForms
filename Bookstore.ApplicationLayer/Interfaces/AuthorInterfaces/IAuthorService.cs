using Bookstore.Domain.Models;

namespace Bookstore.ApplicationLayer.Interfaces.AuthorInterfaces;

public interface IAuthorService
{
    List<Author> GetAuthorList();
}
