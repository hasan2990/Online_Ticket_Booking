﻿using Online_Ticket_Booking.Models.Authentication;

namespace Online_Ticket_Booking.Models
{
    public class Booking : User
    {
        public int? booking_id { get; set; }

        public new int? user_id { get; set; }

        public int? route_id { get; set; }

        public int? bus_id { get; set; }

        public DateTime ending_time { get; set; }

        public string? seat_no { get; set; }
        public bool? isBooked { get; set; }
        public required bool isPaid { get; set; }
    }
}
