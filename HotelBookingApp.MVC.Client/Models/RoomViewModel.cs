namespace HotelBookingApp.MVC.Client.Models
{
    public class RoomViewModel
    {
        public int RoomID { get; set; }

        public int RoomNumber { get; set; }

        public string RoomType { get; set; } = string.Empty;

        public bool RoomAvailable { get; set; } = false;

        public int HotelID { get; set; }
    }
}