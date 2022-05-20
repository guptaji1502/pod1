using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HRMS6.Data;
using HouseRentalManagementApp.Models;

namespace HRMS6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingsController : ControllerBase
    {
      

        [HttpGet]
        public IActionResult Gets()
        {
            if (bookings.Count == 0)
            {
                return NotFound("No List Found");
            }
            return Ok(bookings);
        }

        [HttpGet("GetStudent")]
        public IActionResult Get(int id)
        {
            var booking = bookings.SingleOrDefault(x => x.BookingId == id);
            if (booking == null)
            {
                return NotFound("No Student Found");
            }
            return Ok(booking);
        }

    }
}
