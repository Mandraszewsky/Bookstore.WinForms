using Bookstore.DomainLayer.Models;

namespace Bookstore.ApplicationLayer.Interfaces.ReservationInterfaces;

public interface IReservationDetailService
{
    List<ReservationDetail> GetReservationDetailsForReservation(Guid id);
    Task AddBookToReservation(ReservationDetail book);
    Task RemoveBookFromReservation(Guid id);
}
