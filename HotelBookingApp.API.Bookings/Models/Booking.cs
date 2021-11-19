using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelBookingApp.API.Bookings.Models
{
    [Table("Booking")]
    public class Booking
    {
        [Key]
        public int BookingID { get; set; }

        [Required]
        [ForeignKey("CustomerID")]
        public int CustomerID { get; set; } = 0;

        [Required]
        public int HotelID { get; set; } = 0;

        [Required]
        public int RoomID { get; set; } = 0;
    }
}