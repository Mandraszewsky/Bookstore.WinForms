using Bookstore.ApplicationLayer.Interfaces.ReservationInterfaces;
using Bookstore.DomainLayer.Enums;
using Bookstore.DomainLayer.Models;

namespace Bookstore.ApplicationLayer.Services.ReservationServices;

public class ReservationService : IReservationService
{
    private readonly IReservationRepository _reservationRepository;

    public ReservationService(IReservationRepository reservationRepository)
    {
        _reservationRepository = reservationRepository;
    }

    public async Task CreateReservation(Reservation reservation)
    {
        await _reservationRepository.CreateReservation(reservation);
    }

    public async Task UpdateReservation(Reservation reservation)
    {
        await _reservationRepository.UpdateReservation(reservation);
    }

    public async Task CompleteReservation(Guid id, ReservationStatusEnum reservationStatus)
    {
        await _reservationRepository.CompleteReservation(id, reservationStatus);
    }

    public async Task<Reservation> GetReservationById(Guid id)
    {
        return await _reservationRepository.GetReservationById(id);
    }

    public async Task<List<Reservation>> GetReservationList()
    {
        return await _reservationRepository.GetReservationList();
    }
}
