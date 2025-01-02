using Bookstore.ApplicationLayer.Interfaces.AuthorInterfaces;
using Bookstore.ApplicationLayer.Interfaces.BookInterfaces;
using Bookstore.ApplicationLayer.Interfaces.CustomerInterfaces;
using Bookstore.ApplicationLayer.Interfaces.ReservationInterfaces;
using Bookstore.ApplicationLayer.Services.AuthorServices;
using Bookstore.ApplicationLayer.Services.BookServices;
using Bookstore.ApplicationLayer.Services.CustomerServices;
using Bookstore.ApplicationLayer.Services.ReservationServices;
using Bookstore.InfrastructureLayer.Repositories;
using Bookstore.WinForms.Forms.AuthorForms;
using Bookstore.WinForms.Forms.BookForms;
using Bookstore.WinForms.Forms.CustomerForms;
using Bookstore.WinForms.Forms.ReservationForms;
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

        services.AddScoped<IBookRepository, BookRepository>();
        services.AddScoped<IReservationRepository, ReservationRepository>();
        services.AddScoped<IAuthorRepository, AuthorRepository>();
        services.AddScoped<ICustomerRepository, CustomerRepository>();

        services.AddTransient<MainForm>();
        services.AddTransient<ReservationForm>();
        services.AddTransient<BookForm>();
        services.AddTransient<AuthorForm>();
        services.AddTransient<CustomerForm>();
    }
}