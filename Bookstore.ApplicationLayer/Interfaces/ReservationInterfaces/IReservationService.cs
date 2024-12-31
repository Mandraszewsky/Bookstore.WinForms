using Bookstore.Domain.Models;

namespace Bookstore.ApplicationLayer.Interfaces.ReservationInterfaces;

public interface IReservationService
{
    List<Reservation> GetReservations();
    Task<Reservation> GetReservation(Guid id);
    Task CreateReservation(Reservation reservation);
}
