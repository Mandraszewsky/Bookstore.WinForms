using Bookstore.ApplicationLayer.Interfaces.ReservationInterfaces;
using Bookstore.ApplicationLayer.Services.ReservationServices;
using Bookstore.DomainLayer.Models;
using Bookstore.DomainLayer.Enums;
using Moq;
using Xunit;

namespace Bookstore.ApplicationLayer.Tests;

public class ReservationServiceTests
{
    private readonly Mock<IReservationRepository> _mockRepository;
    private readonly ReservationService _service;

    public ReservationServiceTests()
    {
        _mockRepository = new Mock<IReservationRepository>();
        _service = new ReservationService(_mockRepository.Object);
    }

    [Fact]
    public async Task GetReservationListAsync_ReturnReservations()
    {
        var expectedReservations = new List<Reservation>
        {
            new Reservation { ReservationID = Guid.Parse("7F5BD197-9776-46C4-8E14-78567649E588"), CustomerID = Guid.Parse("CD051749-7EA6-4870-B2E9-B96824615A0E"), CustomerName = "CustomerName #1", EmailAddress = "customer1@gmail.com", ReservationStatus = ReservationStatusEnum.InProgress, ReservationDate = DateTime.Now},
            new Reservation { ReservationID = Guid.Parse("CEBA6B87-28C0-4AC3-ADCB-A0B56DDC49DF"), CustomerID = Guid.Parse("64BBCADB-28AC-43C6-BCFC-3B1D14B85E31"), CustomerName = "CustomerName #2", EmailAddress = "customer2@gmail.com", ReservationStatus = ReservationStatusEnum.Finished, ReservationDate = DateTime.Now},
        };

        _mockRepository.Setup(x => x.GetReservationList()).ReturnsAsync(expectedReservations);

        var result = await _service.GetReservationList();

        Assert.NotNull(result);
        Assert.Equal(2, result.Count());
        Assert.Equal(expectedReservations, result);
    }

    [Fact]
    public async Task GetReservationByIdAsync_ReturnReservation()
    {
        var reservationId = Guid.Parse("7F5BD197-9776-46C4-8E14-78567649E588");
        var expectedReservation = new Reservation { ReservationID = reservationId, CustomerID = Guid.Parse("CD051749-7EA6-4870-B2E9-B96824615A0E"), CustomerName = "CustomerName #1", EmailAddress = "customer1@gmail.com", ReservationStatus = ReservationStatusEnum.InProgress, ReservationDate = DateTime.Now };

        _mockRepository.Setup(x => x.GetReservationById(reservationId)).ReturnsAsync(expectedReservation);

        var result = await _service.GetReservationById(reservationId);

        Assert.NotNull(result);
        Assert.Equal(expectedReservation, result);
    }

    [Fact]
    public async Task AddReservationAsync_RepositoryMethodCall()
    {
        var reservation = new Reservation { ReservationID = Guid.Parse("7F5BD197-9776-46C4-8E14-78567649E588"), CustomerID = Guid.Parse("CD051749-7EA6-4870-B2E9-B96824615A0E"), CustomerName = "CustomerName #1", EmailAddress = "customer1@gmail.com", ReservationStatus = ReservationStatusEnum.InProgress, ReservationDate = DateTime.Now };

        await _service.CreateReservation(reservation);

        _mockRepository.Verify(x => x.CreateReservation(reservation), Times.Once);
    }

    [Fact]
    public async Task UpdateReservationAsync_RepositoryMethodCall()
    {
        var reservation = new Reservation { ReservationID = Guid.Parse("7F5BD197-9776-46C4-8E14-78567649E588"), CustomerID = Guid.Parse("CD051749-7EA6-4870-B2E9-B96824615A0E"), CustomerName = "CustomerName #1", EmailAddress = "customer1@gmail.com", ReservationStatus = ReservationStatusEnum.Finished, ReservationDate = DateTime.Now };

        await _service.UpdateReservation(reservation);

        _mockRepository.Verify(x => x.UpdateReservation(reservation), Times.Once);
    }
}
