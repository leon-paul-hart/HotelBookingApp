using HotelBookingApp.API.Bookings.Models;

using Microsoft.EntityFrameworkCore;

namespace HotelBookingApp.API.Bookings.Data
{
    public class BookingContext : DbContext
    {
        public DbSet<Booking> Booking { get; set; } = null!;

        public BookingContext(DbContextOptions<BookingContext> options) : base(options)
        {

        }
    }
}