using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelBookingApp.API.Hotels.Models
{
    [Table("Hotel")]
    public class Hotel
    {
        [Key]
        public int HotelID { get; set; }

        public string HotelName { get; set; } = string.Empty;

        public string HotelStreetAddress { get; set; } = string.Empty;

        public string HotelPostcode { get; set; } = string.Empty;

        public ICollection<Room> HotelRooms { get; set; } = new List<Room>();
    }
}


