﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Online_Ticket_Booking.Models;
using Online_Ticket_Booking.Models.Responses;
using Online_Ticket_Booking.Services.Interfaces;
using System;
using System.Threading.Tasks;

namespace Online_Ticket_Booking.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IBookingService _bookingService;

        public BookingController(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> GetBookings([FromQuery] BookingQueryParameters queryParameters)
        {
            try
            {
                var result = await _bookingService.GetBookingsAsync(queryParameters);

                if (result.isSuccess)
                {
                    return Ok(result);
                }
                else
                {
                    return StatusCode(500, result.statusMessage);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
