﻿using Dapper;
using Online_Ticket_Booking.Models;
using Online_Ticket_Booking.Models.Data;
using Online_Ticket_Booking.Repositories.Interfaces;

namespace Online_Ticket_Booking.Repositories.Implemantations
{
    public class RoadRepo : IRoadRepo
    {
        private readonly AppDbContext _appDbContext;
        public RoadRepo(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<string> RoadUser(RoadInfo use)
        {
            string query = @"INSERT INTO Routes (source_id, destination_id, distance, duration) VALUES (@source_id, @destination_id, @distance, @duration)";

            int rowsAffected = 0;
            using (var connection = this._appDbContext.Connection())
            {

                rowsAffected = await connection.ExecuteAsync(query, use);

                if (rowsAffected > 0)
                {
                    return "Route details are added to the database";
                }
                else
                {
                    return "Error";
                }
            }
        }
    }
}
