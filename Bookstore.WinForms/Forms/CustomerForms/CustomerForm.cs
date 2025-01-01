using Bookstore.ApplicationLayer.Interfaces.CustomerInterfaces;
using Bookstore.DomainLayer.Models;

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

    void FillCustomersGridView()
    {
        var customers = new List<Customer>();

        customers = _customerService.GetCustomerList();

        customersDataGridView.DataSource = customers;
    }
}
