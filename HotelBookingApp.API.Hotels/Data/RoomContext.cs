using HotelBookingApp.API.Hotels.Models;

using Microsoft.EntityFrameworkCore;

namespace HotelBookingApp.API.Hotels.Data
{
    public class RoomContext : DbContext
    {
        public DbSet<Room> Room { get; set; } = null!;

        public RoomContext(DbContextOptions<RoomContext> options) : base(options)
        {
        }
    }
}