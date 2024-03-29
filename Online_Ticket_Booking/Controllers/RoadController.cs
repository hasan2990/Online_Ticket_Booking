﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Online_Ticket_Booking.Models;
using Online_Ticket_Booking.Services.Interfaces;

namespace Online_Ticket_Booking.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoadController : ControllerBase
    {
        private readonly IRoadService _roadService;
        public RoadController(IRoadService roadService)
        {
            _roadService = roadService;
        }
        [HttpPost]
        [Route("RoadDetails")]

        public async Task<IActionResult> RoadDetails(RoadInfo use)
        {
            var roadinfo = await _roadService.ServiceRoadUser(use);
            return Ok(roadinfo);
        }
    }
}
