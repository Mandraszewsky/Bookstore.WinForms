using Bookstore.ApplicationLayer.Interfaces.BookInterfaces;
using Bookstore.ApplicationLayer.Services.BookServices;
using Microsoft.Extensions.DependencyInjection;

namespace Bookstore.WinForms;

internal static class Program
{
    public static IServiceProvider? ServiceProvider { get; private set; }

    [STAThread]
    static void Main()
    {
        var services = new ServiceCollection();

        ConfigureServices(services);

        ApplicationConfiguration.Initialize();

        var booksService = services.BuildServiceProvider().GetRequiredService<IBookService>();
        var authorService = services.BuildServiceProvider().GetRequiredService<IAuthorService>();

        Application.Run(new BooksForm(booksService, authorService));
    }

    private static void ConfigureServices(IServiceCollection services)
    {
        services.AddScoped<IBookService, BookService>();
        services.AddScoped<IAuthorService, AuthorService>();
    }
}