namespace HotelBookingApp.API.Hotels.Models
{
    public class Room
    {
        public int RoomID { get; set; }

        public int RoomNumber { get; set; }

        public string RoomType { get; set; } = string.Empty;

        public bool RoomAvailable { get; set; }
    }
}