using Bookstore.ApplicationLayer.Interfaces.ReservationInterfaces;
using Bookstore.DomainLayer.Models;
using Bookstore.InfrastructureLayer.Data;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Bookstore.InfrastructureLayer.Repositories;

public class ReservationDetailRepository : IReservationDetailRepository
{
    private readonly string connectionString = DatabaseConfig.ConnectionString;

    public async Task AddBookToReservation(ReservationDetail reservationDetail)
    {
        SqlConnection conn = new SqlConnection(connectionString);

        var command = new SqlCommand("AddBookToReservation", conn);
        command.CommandType = CommandType.StoredProcedure;

        command.Parameters.Add(new SqlParameter("@ReservationID", reservationDetail.ReservationID));
        command.Parameters.Add(new SqlParameter("@BookID", reservationDetail.BookID));

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

    public async Task RemoveBookFromReservation(Guid id)
    {
        SqlConnection conn = new SqlConnection(connectionString);

        var command = new SqlCommand("RemoveBookFromReservation", conn);
        command.CommandType = CommandType.StoredProcedure;

        command.Parameters.Add(new SqlParameter("@ReservationDetailID", id));

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

    public async Task<List<ReservationDetail>> GetReservationDetailsForReservation(Guid id)
    {
        List<ReservationDetail> reservationDetailList = new List<ReservationDetail>();

        SqlConnection conn = new SqlConnection(connectionString);

        string querySQL = $"SELECT ReservationDetailID, ReservationID, BookID, Title, ISBN FROM GetReservationDetailsView WHERE ReservationID = '{id}'";

        try
        {
            await conn.OpenAsync();

            var command = new SqlCommand(querySQL, conn);
            var dataReader = await command.ExecuteReaderAsync();

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

            await conn.CloseAsync();

            return reservationDetailList;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
}
