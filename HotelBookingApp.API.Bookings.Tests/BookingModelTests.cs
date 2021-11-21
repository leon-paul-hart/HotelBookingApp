using HotelBookingApp.API.Bookings.Models;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HotelBookingApp.API.Bookings.Tests
{
    [TestClass]
    public class BookingModelTests
    {
        [TestMethod]
        public void NewBookingModel_NotNull()
        {
            // Arrange
            Booking booking = new();

            // Act

            // Assert
            Assert.IsNotNull(booking);
        }

        [TestMethod]
        public void NewBookingModel_BookingID_NotNull()
        {
            // Arrange
            Booking booking = new();

            // Act

            // Assert
            Assert.IsNotNull(booking.BookingID);
        }

        [TestMethod]
        public void NewBookingModel_CustomerID_NotNull()
        {
            // Arrange
            Booking booking = new();

            // Act

            // Assert
            Assert.IsNotNull(booking.CustomerID);
        }

        [TestMethod]
        public void NewBookingModel_HotelID_NotNull()
        {
            // Arrange
            Booking booking = new();

            // Act

            // Assert
            Assert.IsNotNull(booking.HotelID);
        }

        [TestMethod]
        public void NewBookingModel_RoomID_NotNull()
        {
            // Arrange
            Booking booking = new();

            // Act

            // Assert
            Assert.IsNotNull(booking.RoomID);
        }
    }
}
