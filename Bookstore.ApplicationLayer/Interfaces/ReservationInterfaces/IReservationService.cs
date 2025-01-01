using Bookstore.DomainLayer.Enums;
using Bookstore.DomainLayer.Models;

namespace Bookstore.ApplicationLayer.Interfaces.ReservationInterfaces;

public interface IReservationService
{
    List<Reservation> GetReservations();
    Task<Reservation> GetReservationById(Guid id);
    Task CreateReservation(Reservation reservation);
    Task UpdateReservation(Reservation reservation);
    Task CompleteReservation(Guid id, ReservationStatusEnum reservationStatus);
}
