using Bookstore.ApplicationLayer.Interfaces.AuthorInterfaces;
using Bookstore.DomainLayer.Models;

namespace Bookstore.ApplicationLayer.Services.AuthorServices;

public class AuthorService : IAuthorService
{
    private readonly IAuthorRepository _authorRepository;

    public AuthorService(IAuthorRepository authorRepository)
    {
        _authorRepository = authorRepository;
    }

    public async Task<List<Author>> GetAuthorList()
    {
        return await _authorRepository.GetAuthorList();
    }
}
