using HotelBookingApp.API.Bookings.Models;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HotelBookingApp.API.Bookings.Tests
{
    [TestClass]
    public class CustomerModelTests
    {
        [TestMethod]
        public void NewCustomerModel_NotNull()
        {
            // Arrange
            Customer customer = new();

            // Act

            // Assert
            Assert.IsNotNull(customer);
        }

        [TestMethod]
        public void NewCustomerModel_CustomerID_NotNull()
        {
            // Arrange
            Customer customer = new();

            // Act

            // Assert
            Assert.IsNotNull(customer.CustomerID);
        }

        [TestMethod]
        public void NewCustomerModel_CustomerName_NotNull()
        {
            // Arrange
            Customer customer = new();

            // Act

            // Assert
            Assert.IsNotNull(customer.CustomerName);
        }

        [TestMethod]
        public void NewCustomerModel_CustomerEmail_NotNull()
        {
            // Arrange
            Customer customer = new();

            // Act

            // Assert
            Assert.IsNotNull(customer.CustomerEmail);
        }

        [TestMethod]
        public void NewCustomerModel_CustomerPhone_NotNull()
        {
            // Arrange
            Customer customer = new();

            // Act

            // Assert
            Assert.IsNotNull(customer.CustomerPhone);
        }

        [TestMethod]
        public void NewCustomerModel_CustomerBookings_NotNull()
        {
            // Arrange
            Customer customer = new();

            // Act

            // Assert
            Assert.IsNotNull(customer.CustomerBookings);
        }
    }
}
