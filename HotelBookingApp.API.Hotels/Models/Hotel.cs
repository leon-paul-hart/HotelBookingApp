namespace HotelBookingApp.API.Hotels.Models
{
    public class Hotel
    {
        public int HotelID { get; set; }

        public string HotelName { get; set; }

        public string HotelStreetAddress { get; set; }

        public string HotelPostcode { get; set; }

        public ICollection<Room>? HotelRooms { get; set; }
    }
}


