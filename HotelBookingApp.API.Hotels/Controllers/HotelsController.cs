﻿using HotelBookingApp.API.Hotels.Data;
using HotelBookingApp.API.Hotels.Models;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HotelBookingApp.API.Hotels.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelsController : ControllerBase
    {
        private readonly HotelContext _context;

        public HotelsController(HotelContext context)
        {
            _context = context;
        }

        // GET: api/Hotels
        /// <summary>
        /// Returns a list of all Hotels in the database.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Hotel>>> GetHotel()
        {
            return await _context.Hotel.ToListAsync();
        }

        // GET: api/Hotels/5
        /// <summary>
        /// Returns a specific Hotel from the database matching the provided valid HotelID.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<Hotel>> GetHotel(int id)
        {
            Hotel? hotel = await _context.Hotel.FindAsync(id);

            if (hotel == null)
            {
                return NotFound();
            }

            return hotel;
        }

        // PUT: api/Hotels/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        /// <summary>
        /// Updates the database details of a particular Hotel when provided with a valid HotelID and updated Hotel model.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="hotel"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHotel(int id, Hotel hotel)
        {
            if (id != hotel.HotelID)
            {
                return BadRequest();
            }

            _context.Entry(hotel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HotelExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Hotels
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        /// <summary>
        /// Adds a new Hotel to the database if provided with a valid Hotel model.
        /// </summary>
        /// <param name="hotel"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult<Hotel>> PostHotel(Hotel hotel)
        {
            _context.Hotel.Add(hotel);

            await _context.SaveChangesAsync();

            return CreatedAtAction("GetHotel", new { id = hotel.HotelID }, hotel);
        }

        // DELETE: api/Hotels/5
        /// <summary>
        /// Deletes a particular Hotel from the database when provided with a valid HotelID.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHotel(int id)
        {
            Hotel? hotel = await _context.Hotel.FindAsync(id);

            if (hotel == null)
            {
                return NotFound();
            }

            _context.Hotel.Remove(hotel);

            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HotelExists(int id)
        {
            return _context.Hotel.Any(e => e.HotelID == id);
        }
    }
}