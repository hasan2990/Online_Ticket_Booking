﻿using Online_Ticket_Booking.Models;

namespace Online_Ticket_Booking.Repositories.Interfaces
{
    public interface IBusRepo
    {
        Task<int> BusUser(BusInfo use);
    }
}
