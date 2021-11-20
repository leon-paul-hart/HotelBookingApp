using HotelBookingApp.API.Hotels.Models;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HotelBookingApp.API.Hotels.Tests
{
    [TestClass]
    public class HotelModelTests
    {
        [TestMethod]
        public void NewHotelModel_NotNull()
        {
            // Arrange
            Hotel hotel = new();

            // Act

            // Assert
            Assert.IsNotNull(hotel);
        }

        [TestMethod]
        public void NewHotelModel_HotelID_NotNull()
        {
            // Arrange
            Hotel hotel = new();

            // Act

            // Assert
            Assert.IsNotNull(hotel.HotelID);
        }

        [TestMethod]
        public void NewHotelModel_HotelName_NotNull()
        {
            // Arrange
            Hotel hotel = new();

            // Act

            // Assert
            Assert.IsNotNull(hotel.HotelName);
        }

        [TestMethod]
        public void NewHotelModel_HotelStreetAddress_NotNull()
        {
            // Arrange
            Hotel hotel = new();

            // Act

            // Assert
            Assert.IsNotNull(hotel.HotelStreetAddress);
        }

        [TestMethod]
        public void NewHotelModel_HotelPostcode_NotNull()
        {
            // Arrange
            Hotel hotel = new();

            // Act

            // Assert
            Assert.IsNotNull(hotel.HotelPostcode);
        }

        [TestMethod]
        public void NewHotelModel_HotelRooms_NotNull()
        {
            // Arrange
            Hotel hotel = new();

            // Act

            // Assert
            Assert.IsNotNull(hotel.HotelRooms);
        }
    }
}