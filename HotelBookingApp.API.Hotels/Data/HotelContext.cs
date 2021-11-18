using HotelBookingApp.API.Hotels.Models;

using Microsoft.EntityFrameworkCore;

namespace HotelBookingApp.API.Hotels.Data
{
    public class HotelContext : DbContext
    {
        public DbSet<Hotel> Hotel { get; set; }

        public HotelContext(DbContextOptions<HotelContext> options) : base(options)
        {

        }
    }
}