﻿using Online_Ticket_Booking.Models.Authentication;

namespace Online_Ticket_Booking.Repositories.Interfaces
{
    public interface IRegistrationRepo
    {
        Task<string> RegisterUser(User registration);
    }
}
