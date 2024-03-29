﻿using System.ComponentModel.DataAnnotations;

namespace Online_Ticket_Booking.Models.Authentication
{
    public class User
    {
        public int user_id { get; set; }

        [Required(ErrorMessage = "UserName is required")]
        public string? username { get; set; }
        [Required(ErrorMessage = "Email is required")]
        public string? email { get; set; }
        [Required(ErrorMessage = "Password is required")]
        public string? password { get; set; }
        public bool isActive { get; set; } = true;
        public string? phone_number { get; set; }
    }
}
