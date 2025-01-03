﻿using Bookstore.DomainLayer.Enums;

namespace Bookstore.DomainLayer.Models;

public class Reservation
{
    public Guid? ReservationID { get; set; }
    public Guid? CustomerID { get; set; }
    public string? CustomerName { get; set; } = default!;
    public string? EmailAddress { get; set; } = default!;
    public ReservationStatusEnum? ReservationStatus { get; set; } = default!;
    public DateTime? ReservationDate { get; set; } = default!;

}
