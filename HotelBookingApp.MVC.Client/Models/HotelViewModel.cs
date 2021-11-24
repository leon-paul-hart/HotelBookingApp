namespace HotelBookingApp.MVC.Client.Models
{
    public class HotelViewModel
    {
        public int HotelID { get; set; }

        public string HotelName { get; set; } = string.Empty;

        public string HotelStreetAddress { get; set; } = string.Empty;

        public string HotelPostcode { get; set; } = string.Empty;

        public List<RoomViewModel> Rooms { get; set; } = new List<RoomViewModel>();
    }
}
