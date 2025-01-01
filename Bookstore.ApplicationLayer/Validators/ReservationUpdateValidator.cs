using Bookstore.DomainLayer.Models;
using FluentValidation;

namespace Bookstore.ApplicationLayer.Validators;

public class ReservationUpdateValidator : AbstractValidator<Reservation>
{
    public ReservationUpdateValidator()
    {
        RuleFor(reservation => reservation.ReservationDate)
            .NotEmpty().WithMessage("Reservation date date is required.");

        RuleFor(reservation => reservation.ReservationStatus)
            .NotEmpty().WithMessage("Reservation status is required.")
            .IsInEnum().WithMessage("Invalid reservation status.");
    }
}
