using Bookstore.DomainLayer.Models;

namespace Bookstore.ApplicationLayer.Interfaces.ReservationInterfaces;

public interface IReservationDetailRepository
{
    Task <List<ReservationDetail>> GetReservationDetailsForReservation(Guid id);
    Task AddBookToReservation(ReservationDetail book);
    Task RemoveBookFromReservation(Guid id);
}
