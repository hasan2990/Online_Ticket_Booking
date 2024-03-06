﻿using Online_Ticket_Booking.Models;
using Online_Ticket_Booking.Models.Responses;

namespace Online_Ticket_Booking.Services.Interfaces
{
    public interface IGetBusesService
    {
       public  Task<SelectedBusesResponse> ServiceGetBuses(SearchBusesInfo use);
    }
}
