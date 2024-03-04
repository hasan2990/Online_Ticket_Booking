﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Online_Ticket_Booking.Models;
using Online_Ticket_Booking.Services.Implemantations;
using Online_Ticket_Booking.Services.Interfaces;
using System;
using System.Threading.Tasks;

namespace Online_Ticket_Booking.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetBusesController : ControllerBase
    {
        private readonly IGetBusesService _getBusesService;

        public GetBusesController(IGetBusesService getBusesService)
        {
            _getBusesService = getBusesService;
        }

        [HttpGet]
        [Route("GetBusDetails")]
        public async Task<IActionResult> GetBusDetails(string source, string destination)
        {
            try
            {
                var searchInfo = new SearchBusesInfo { source = source, destination = destination };
                var buses = await _getBusesService.ServiceGetBuses(searchInfo);
                return Ok(buses);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
    }
}