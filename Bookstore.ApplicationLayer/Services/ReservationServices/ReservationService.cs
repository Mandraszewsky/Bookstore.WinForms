using Bookstore.ApplicationLayer.Interfaces.ReservationInterfaces;
using Bookstore.DomainLayer.Enums;
using Bookstore.DomainLayer.Models;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Bookstore.ApplicationLayer.Services.ReservationServices;

public class ReservationService : IReservationService
{
    private readonly string connectionString = @"Data Source=DESKTOP-I57J3OL;Initial Catalog=BookstoreDB;User Id=sa;Password=sa1234;Integrated Security=True;MultipleActiveResultSets=true;TrustServerCertificate=True;";

    public Task CreateReservation(Reservation reservation)
    {
        SqlConnection conn = new SqlConnection(connectionString);

        var command = new SqlCommand("CreateReservation", conn);
        command.CommandType = CommandType.StoredProcedure;

        command.Parameters.Add(new SqlParameter("@CustomerName", reservation.CustomerName));
        command.Parameters.Add(new SqlParameter("@ReservationStatus", reservation.ReservationStatus));
        command.Parameters.Add(new SqlParameter("@ReservationDate", reservation.ReservationDate));

        try
        {
            conn.Open();

            command.ExecuteNonQuery();

            conn.Close();
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }

        return Task.CompletedTask;
    }

    public async Task<Reservation> GetReservation(Guid id)
    {
        Reservation reservation = new Reservation();

        SqlConnection conn = new SqlConnection(connectionString);

        string querySQL = $"SELECT ReservationID, ReservationDate, CustomerID, CustomerName, EmailAddress FROM GetReservationView WHERE ReservationID = '{id}'";

        try
        {
            conn.Open();

            var command = new SqlCommand(querySQL, conn);
            var dataReader = command.ExecuteReader();

            if (dataReader != null)
            {
                while (dataReader.Read())
                {
                    reservation.ReservationID = Guid.Parse(dataReader["ReservationID"].ToString()!);
                    reservation.ReservationDate = DateTime.Now;
                    reservation.CustomerID = Guid.Parse(dataReader["CustomerID"].ToString()!);
                    reservation.CustomerName = dataReader["CustomerName"].ToString();
                    reservation.EmailAddress = dataReader["EmailAddress"].ToString();
                }
            }

            conn.Close();

            return reservation;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public List<Reservation> GetReservations()
    {
        List<Reservation> reservationList = new List<Reservation>();

        SqlConnection conn = new SqlConnection(connectionString);

        string querySQL = "SELECT ReservationID, ReservationStatus, ReservationDate, CustomerID, CustomerName, EmailAddress FROM GetReservationView";

        try
        {
            conn.Open();

            var command = new SqlCommand(querySQL, conn);
            var dataReader = command.ExecuteReader();

            if (dataReader != null)
            {
                while (dataReader.Read())
                {
                    Reservation reservation = new Reservation();

                    reservation.ReservationID = Guid.Parse(dataReader["ReservationID"].ToString()!);
                    reservation.ReservationStatus = (ReservationStatusEnum)Convert.ToInt32(dataReader["ReservationStatus"].ToString());
                    reservation.ReservationDate = DateTime.Parse(dataReader["ReservationDate"].ToString()!);
                    reservation.CustomerID = Guid.Parse(dataReader["CustomerID"].ToString()!);
                    reservation.CustomerName = dataReader["CustomerName"].ToString();
                    reservation.EmailAddress = dataReader["EmailAddress"].ToString();

                    reservationList.Add(reservation);
                }
            }

            conn.Close();

            return reservationList;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
}
