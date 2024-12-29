using Bookstore.Domain.Models;

namespace Bookstore.ApplicationLayer.Interfaces.BookInterfaces;

public interface IAuthorService
{
    List<Author> GetAuthorList();
}
