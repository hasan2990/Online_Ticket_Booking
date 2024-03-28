﻿namespace Online_Ticket_Booking.Models
{
    public class PriceInfo
    {
        public int bus_id { get; set; }
        public string? bus_name { get; set; }
        public int route_id { get; set; }
        public int capacity { get; set; }
        public int seatCount { get; set; }
        public string? source { get; set; }
        public string? destination { get; set; }
        public decimal? price { get; set; }


    }
}
