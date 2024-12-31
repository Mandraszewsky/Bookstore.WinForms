namespace Bookstore.Domain.Models;

public class ReservationDetail
{
    public Guid? ReservationDetailID { get; set; }
    public Guid? ReservationID { get; set; }
    public Guid? BookID { get; set; }
    public string? BookISBN { get; set; }
    public string? BookTitle { get; set; }
}
