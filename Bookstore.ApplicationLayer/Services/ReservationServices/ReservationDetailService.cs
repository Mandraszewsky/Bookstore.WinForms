using Bookstore.ApplicationLayer.Interfaces.ReservationInterfaces;
using Bookstore.DomainLayer.Models;
using Microsoft.Data.SqlClient;

namespace Bookstore.ApplicationLayer.Services.ReservationServices;

public class ReservationDetailService : IReservationDetailService
{
    private readonly string connectionString = @"Data Source=DESKTOP-I57J3OL;Initial Catalog=BookstoreDB;User Id=sa;Password=sa1234;Integrated Security=True;MultipleActiveResultSets=true;TrustServerCertificate=True;";

    public List<ReservationDetail> GetReservationDetailsForReservation(Guid id)
    {
        List<ReservationDetail> reservationDetailList = new List<ReservationDetail>();

        SqlConnection conn = new SqlConnection(connectionString);

        string querySQL = $"SELECT ReservationDetailID, ReservationID, BookID, Title, ISBN FROM GetReservationDetailsView WHERE ReservationID = '{id}'";

        try
        {
            conn.Open();

            var command = new SqlCommand(querySQL, conn);
            var dataReader = command.ExecuteReader();

            if (dataReader != null)
            {
                while (dataReader.Read())
                {
                    ReservationDetail reservationDetail = new ReservationDetail();

                    reservationDetail.ReservationDetailID = Guid.Parse(dataReader["ReservationDetailID"].ToString()!);
                    reservationDetail.ReservationID = Guid.Parse(dataReader["ReservationID"].ToString()!);
                    reservationDetail.BookID = Guid.Parse(dataReader["BookID"].ToString()!);
                    reservationDetail.BookISBN = dataReader["ISBN"].ToString();
                    reservationDetail.BookTitle = dataReader["Title"].ToString();

                    reservationDetailList.Add(reservationDetail);
                }
            }

            conn.Close();

            return reservationDetailList;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
}
