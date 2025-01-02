using Bookstore.DomainLayer.Models;
using FluentValidation;

namespace Bookstore.ApplicationLayer.Validators;

public class BookValidator : AbstractValidator<Book>
{
    public BookValidator()
    {
        RuleFor(book => book.ISBN)
            .NotEmpty().WithMessage("ISBN is required.")
            .Length(13).WithMessage("ISBN must be exactly 13 characters long.");

        RuleFor(book => book.Title)
            .NotEmpty().WithMessage("Title is required.")
            .MaximumLength(50).WithMessage("Title must be a maximum of 50 characters.");

        RuleFor(book => book.Description)
            .NotEmpty().WithMessage("Description is required.")
            .MaximumLength(50).WithMessage("Description must be a maximum of 50 characters.");

        RuleFor(book => book.PagesNumber)
            .NotEmpty().WithMessage("Pages number is required.")
            .Must(value => value is int).WithMessage("Quantity must be of type int.");

        RuleFor(book => book.Quantity)
            .NotEmpty().WithMessage("Quantity is required.")
            .Must(value => value is int).WithMessage("Quantity must be of type int.");

        RuleFor(book => book.PublicationDate)
            .NotEmpty().WithMessage("Publication date is required.");
    }
}
