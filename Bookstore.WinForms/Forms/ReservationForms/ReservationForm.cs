﻿using Bookstore.ApplicationLayer.Interfaces.BookInterfaces;
using Bookstore.ApplicationLayer.Interfaces.CustomerInterfaces;
using Bookstore.ApplicationLayer.Interfaces.ReservationInterfaces;
using Bookstore.DomainLayer.Models;
using Bookstore.WinForms.Extensions.CustomizeFormViewExtensions;

namespace Bookstore.WinForms.Forms.ReservationForms;

public partial class ReservationForm : Form
{
    private readonly IReservationService _reservationService;
    private readonly IReservationDetailService _reservationDetailService;
    private readonly IBookService _bookService;
    private readonly ICustomerService _customerService;

    public ReservationForm(IReservationService reservationService, IReservationDetailService reservationDetailService, IBookService bookService, ICustomerService customerService)
    {
        _reservationService = reservationService;
        _reservationDetailService = reservationDetailService;
        _bookService = bookService;
        _customerService = customerService;

        InitializeComponent();
        FillReservationsGridView();
    }

    private async void FillReservationsGridView()
    {
        var reservations = new List<Reservation>();

        reservations = await _reservationService.GetReservationList();

        reservationsDataGridView.DataSource = reservations;

        reservationsDataGridView.CustomizeReservationsGridView();
    }

    private void ChildForm_FormClosed(object sender, FormClosedEventArgs e)
    {
        FillReservationsGridView();
    }

    private void reservationDetailsButton_Click(object sender, EventArgs e)
    {
        var reservationId = (Guid)reservationsDataGridView.CurrentRow.Cells[0].Value;

        ReservationDetailsForm reservationDetailsForm = new ReservationDetailsForm(reservationId, _reservationDetailService, _bookService);
        reservationDetailsForm.ShowDialog();
    }

    private void addReservationButton_Click(object sender, EventArgs e)
    {
        AddReservationForm addReservationForm = new AddReservationForm(_customerService, _reservationService);
        addReservationForm.FormClosed += ChildForm_FormClosed;
        addReservationForm.ShowDialog();
    }

    private void editReservationButton_Click(object sender, EventArgs e)
    {
        var reservationId = (Guid)reservationsDataGridView.CurrentRow.Cells[0].Value;

        EditReservationForm editReservationForm = new EditReservationForm(reservationId, _reservationService);
        editReservationForm.FormClosed += ChildForm_FormClosed;
        editReservationForm.ShowDialog();
    }
}
