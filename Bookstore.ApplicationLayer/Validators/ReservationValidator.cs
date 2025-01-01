using Bookstore.DomainLayer.Models;
using FluentValidation;

namespace Bookstore.ApplicationLayer.Validators;

public class ReservationValidator : AbstractValidator<Reservation>
{
    public ReservationValidator()
    {
        RuleFor(reservation => reservation.CustomerName)
            .NotEmpty().WithMessage("Customer name is required.")
            .MaximumLength(50).WithMessage("Customer name must be a maximum of 100 characters.");

        RuleFor(reservation => reservation.ReservationDate)
            .NotEmpty().WithMessage("Reservation date date is required.");

        RuleFor(reservation => reservation.ReservationStatus)
            .NotEmpty().WithMessage("Reservation status is required.")
            .IsInEnum().WithMessage("Invalid reservation status.");
    }
}
