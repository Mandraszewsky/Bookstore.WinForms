using Bookstore.ApplicationLayer.Interfaces.ReservationInterfaces;
using Bookstore.DomainLayer.Enums;
using Bookstore.DomainLayer.Models;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Bookstore.InfrastructureLayer.Repositories;

public class ReservationRepository : IReservationRepository
{
    private readonly string connectionString = @"Data Source=DESKTOP-I57J3OL;Initial Catalog=BookstoreDB;User Id=sa;Password=sa1234;Integrated Security=True;MultipleActiveResultSets=true;TrustServerCertificate=True;";

    public async Task CreateReservation(Reservation reservation)
    {
        SqlConnection conn = new SqlConnection(connectionString);

        var command = new SqlCommand("CreateReservation", conn);
        command.CommandType = CommandType.StoredProcedure;

        command.Parameters.Add(new SqlParameter("@CustomerName", reservation.CustomerName));
        command.Parameters.Add(new SqlParameter("@ReservationStatus", reservation.ReservationStatus));
        command.Parameters.Add(new SqlParameter("@ReservationDate", reservation.ReservationDate));

        try
        {
            await conn.OpenAsync();

            await command.ExecuteNonQueryAsync();

            await conn.CloseAsync();
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public async Task UpdateReservation(Reservation reservation)
    {
        SqlConnection conn = new SqlConnection(connectionString);

        var command = new SqlCommand("UpdateReservation", conn);
        command.CommandType = CommandType.StoredProcedure;

        command.Parameters.Add(new SqlParameter("@ReservationID", reservation.ReservationID));
        command.Parameters.Add(new SqlParameter("@ReservationDate", reservation.ReservationDate));
        command.Parameters.Add(new SqlParameter("@ReservationStatus", reservation.ReservationStatus));

        try
        {
            await conn.OpenAsync();

            await command.ExecuteNonQueryAsync();

            await conn.CloseAsync();
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public async Task CompleteReservation(Guid id, ReservationStatusEnum reservationStatus)
    {
        SqlConnection conn = new SqlConnection(connectionString);

        var command = new SqlCommand("CompleteReservation", conn);
        command.CommandType = CommandType.StoredProcedure;

        command.Parameters.Add(new SqlParameter("@ReservationID", id));
        command.Parameters.Add(new SqlParameter("@ReservationStatus", reservationStatus));

        try
        {
            await conn.OpenAsync();

            await command.ExecuteNonQueryAsync();

            await conn.CloseAsync();
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public async Task<Reservation> GetReservationById(Guid id)
    {
        Reservation reservation = new Reservation();

        SqlConnection conn = new SqlConnection(connectionString);

        string querySQL = $"SELECT ReservationID, ReservationStatus, ReservationDate, CustomerID, CustomerName, EmailAddress FROM GetReservationView WHERE ReservationID = '{id}'";

        try
        {
            await conn.OpenAsync();

            var command = new SqlCommand(querySQL, conn);
            var dataReader = await command.ExecuteReaderAsync();

            if (dataReader != null)
            {
                while (dataReader.Read())
                {
                    reservation.ReservationID = Guid.Parse(dataReader["ReservationID"].ToString()!);
                    reservation.ReservationStatus = (ReservationStatusEnum)Convert.ToInt32(dataReader["ReservationStatus"].ToString());
                    reservation.ReservationDate = DateTime.Parse(dataReader["ReservationDate"].ToString()!);
                    reservation.CustomerID = Guid.Parse(dataReader["CustomerID"].ToString()!);
                    reservation.CustomerName = dataReader["CustomerName"].ToString();
                    reservation.EmailAddress = dataReader["EmailAddress"].ToString();
                }
            }

            await conn.CloseAsync();

            return reservation;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public async Task<List<Reservation>> GetReservations()
    {
        List<Reservation> reservationList = new List<Reservation>();

        SqlConnection conn = new SqlConnection(connectionString);

        string querySQL = "SELECT ReservationID, ReservationStatus, ReservationDate, CustomerID, CustomerName, EmailAddress FROM GetReservationView";

        try
        {
            await conn.OpenAsync();

            var command = new SqlCommand(querySQL, conn);
            var dataReader = await command.ExecuteReaderAsync();

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

            await conn.CloseAsync();

            return reservationList;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
}
