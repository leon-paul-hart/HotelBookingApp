using HotelBookingApp.API.Hotels.Models;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public void NewHotelModel_ID_NotNull()
        {
            // Arrange
            Hotel hotel = new();

            // Act

            // Assert
            Assert.IsNotNull(hotel.HotelID);
        }

        [TestMethod]
        public void NewHotelModel_Name_NotNull()
        {
            // Arrange
            Hotel hotel = new();

            // Act

            // Assert
            Assert.IsNotNull(hotel.HotelName);
        }

        [TestMethod]
        public void NewHotelModel_StreetAddress_NotNull()
        {
            // Arrange
            Hotel hotel = new();

            // Act

            // Assert
            Assert.IsNotNull(hotel.HotelStreetAddress);
        }

        [TestMethod]
        public void NewHotelModel_Postcode_NotNull()
        {
            // Arrange
            Hotel hotel = new();

            // Act

            // Assert
            Assert.IsNotNull(hotel.HotelPostcode);
        }

        [TestMethod]
        public void NewHotelModel_RoomList_NotNull()
        {
            // Arrange
            Hotel hotel = new();

            // Act

            // Assert
            Assert.IsNotNull(hotel.HotelRooms);
        }
    }
}
