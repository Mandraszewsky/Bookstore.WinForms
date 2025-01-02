using Bookstore.ApplicationLayer.Interfaces.CustomerInterfaces;
using Bookstore.DomainLayer.Models;
using Bookstore.WinForms.Extensions.CustomizeFormViewExtensions;

namespace Bookstore.WinForms.Forms.CustomerForms;

public partial class CustomerForm : Form
{
    private readonly ICustomerService _customerService;

    public CustomerForm(ICustomerService customerService)
    {
        _customerService = customerService;

        InitializeComponent();
        FillCustomersGridView();
    }

    private async void FillCustomersGridView()
    {
        var customers = new List<Customer>();

        customers = await _customerService.GetCustomerList();

        customersDataGridView.DataSource = customers;

        customersDataGridView.CustomizeCustomersGridView();
    }
}
