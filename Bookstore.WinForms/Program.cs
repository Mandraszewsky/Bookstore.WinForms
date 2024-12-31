using Bookstore.ApplicationLayer.Interfaces.AuthorInterfaces;
using Bookstore.ApplicationLayer.Interfaces.BookInterfaces;
using Bookstore.ApplicationLayer.Interfaces.CustomerInterfaces;
using Bookstore.ApplicationLayer.Interfaces.ReservationInterfaces;
using Bookstore.ApplicationLayer.Services.AuthorServices;
using Bookstore.ApplicationLayer.Services.BookServices;
using Bookstore.ApplicationLayer.Services.CustomerServices;
using Bookstore.ApplicationLayer.Services.ReservationServices;
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
        ServiceProvider = services.BuildServiceProvider();

        ApplicationConfiguration.Initialize();

        //var booksService = services.BuildServiceProvider().GetRequiredService<IBookService>();
        //var authorService = services.BuildServiceProvider().GetRequiredService<IAuthorService>();

        var booksForm = ServiceProvider.GetRequiredService<MainForm>();

        Application.Run(booksForm);
    }

    private static void ConfigureServices(IServiceCollection services)
    {
        services.AddScoped<IBookService, BookService>();
        services.AddScoped<IAuthorService, AuthorService>();
        services.AddScoped<ICustomerService, CustomerService>();
        services.AddScoped<IReservationService, ReservationService>();
        services.AddScoped<IReservationDetailService, ReservationDetailService>();

        services.AddScoped<MainForm>();
    }
}