using HotelBookingApp.API.Bookings.Models;

using Microsoft.EntityFrameworkCore;

namespace HotelBookingApp.API.Bookings.Data
{
    public class CustomerContext : DbContext
    {
        public DbSet<Customer> Customer { get; set; } = null!;

        public CustomerContext(DbContextOptions<CustomerContext> options) : base(options)
        {
        }
    }
}