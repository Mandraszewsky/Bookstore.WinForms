using Bookstore.ApplicationLayer.Interfaces.ReservationInterfaces;
using Bookstore.DomainLayer.Models;

namespace Bookstore.ApplicationLayer.Services.ReservationServices;

public class ReservationDetailService : IReservationDetailService
{
    private readonly IReservationDetailRepository _reservationDetailRepository;

    public ReservationDetailService(IReservationDetailRepository reservationDetailRepository)
    {
        _reservationDetailRepository = reservationDetailRepository;
    }

    public async Task AddBookToReservation(ReservationDetail reservationDetail)
    {
        await _reservationDetailRepository.AddBookToReservation(reservationDetail);
    }

    public async Task RemoveBookFromReservation(Guid id)
    {
        await _reservationDetailRepository.RemoveBookFromReservation(id);
    }

    public async Task<List<ReservationDetail>> GetReservationDetailsForReservation(Guid id)
    {
        return await _reservationDetailRepository.GetReservationDetailsForReservation(id);
    }
}
