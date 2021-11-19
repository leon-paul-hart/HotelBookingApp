using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelBookingApp.API.Hotels.Models
{
    [Table("Room")]
    public class Room
    {
        [Key]
        public int RoomID { get; set; }

        [Required]
        public int RoomNumber { get; set; }

        [Required]
        public string RoomType { get; set; } = string.Empty;

        public bool RoomAvailable { get; set; }

        [ForeignKey("HotelID")]
        public int HotelID { get; set; }
    }
}