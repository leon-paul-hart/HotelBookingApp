using HotelBookingApp.API.Hotels.Models;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HotelBookingApp.API.Hotels.Tests
{
    [TestClass]
    public class RoomModelTests
    {
        [TestMethod]
        public void NewRoomModel_NotNull()
        {
            // Arrange
            Room room = new();

            // Act

            // Assert
            Assert.IsNotNull(room);
        }

        [TestMethod]
        public void NewRoomModel_ID_NotNull()
        {
            // Arrange
            Room room = new();

            // Act

            // Assert
            Assert.IsNotNull(room.RoomID);
        }

        [TestMethod]
        public void NewRoomModel_Number_NotNull()
        {
            // Arrange
            Room room = new();

            // Act

            // Assert
            Assert.IsNotNull(room.RoomNumber);
        }

        [TestMethod]
        public void NewRoomModel_RoomType_NotNull()
        {
            // Arrange
            Room room = new();

            // Act

            // Assert
            Assert.IsNotNull(room.RoomType);
        }

        [TestMethod]
        public void NewRoomModel_RoomAvailable_NotNull()
        {
            // Arrange
            Room room = new();

            // Act

            // Assert
            Assert.IsNotNull(room.RoomAvailable);
        }
    }
}