﻿using System.Threading.Tasks;
using Online_Ticket_Booking.Models.Responses;

namespace Online_Ticket_Booking.Services.Interfaces
{
    public interface ILoginService
    {
        Task<bool> CheckEmailExists(string email);
        Task<LoginResponse> ServiceLoginUser(string email, string password);
        //Task<string> GenerateTokenService(string email);
    }
}
