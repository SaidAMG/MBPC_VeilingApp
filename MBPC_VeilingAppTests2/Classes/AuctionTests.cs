using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MBPC_VeilingApp.Classes.Tests
{
    [TestClass()]
    public class AuctionTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SetName_TooLong_ShouldThrowArgumentException()
        {
            // Arrange/Act
            var auction = new Auction(1, new Member(1, "Auctioneer", "LastName", "Address", "City", "12345", "Country", 1, "email@example.com", DateTime.Now, DateTime.Now, "1234567890"), "NameTooLong123", "Description", DateTime.Now, DateTime.Now);

            // Assert is handled by ExpectedException
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SetDescription_TooLong_ShouldThrowArgumentException()
        {
            // Arrange/Act
            var auction = new Auction(1, new Member(1, "Auctioneer", "LastName", "Address", "City", "12345", "Country", 1, "email@example.com", DateTime.Now, DateTime.Now, "1234567890"), "Name", "This description is definitely way too long and should cause an exception to be thrown", DateTime.Now, DateTime.Now);

            // Assert is handled by ExpectedException
        }

        [TestMethod]
        public void SetName_ValidName_ShouldUpdateName()
        {
            // Arrange
            var member = new Member(1, "Auctioneer", "LastName", "Address", "City", "12345", "Country", 1, "email@example.com", DateTime.Now, DateTime.Now, "1234567890");
            var auction = new Auction(1, member, "InitName", "Description", DateTime.Now, DateTime.Now);
            var newName = "NewName";

            // Act
            auction.SetName(newName);

            // Assert
            Assert.AreEqual(newName, auction.GetName());
        }

        [TestMethod]
        public void SetDescription_ValidDescription_ShouldUpdateDescription()
        {
            // Arrange
            var auction = new Auction(1, new Member(1, "Auctioneer", "LastName", "Address", "City", "12345", "Country", 1, "email@example.com", DateTime.Now, DateTime.Now, "1234567890"), "Name", "InitialDescription", DateTime.Now, DateTime.Now);
            var newDescription = "New Description";

            // Act
            auction.SetDescription(newDescription);

            // Assert
            Assert.AreEqual(newDescription, auction.GetDescription());
        }

        [TestMethod]
        public void SetStartDate_ValidStartDate_ShouldUpdateStartDate()
        {
            // Arrange
            var initialStartDate = DateTime.Now;
            var auction = new Auction(1, new Member(1, "Auctioneer", "LastName", "Address", "City", "12345", "Country", 1, "email@example.com", DateTime.Now, DateTime.Now, "1234567890"), "Name", "Description", initialStartDate, DateTime.Now);
            var newStartDate = initialStartDate.AddDays(1);

            // Act
            auction.SetStartDate(newStartDate);

            // Assert
            Assert.AreEqual(newStartDate, auction.GetStartDate());
        }

        [TestMethod]
        public void SetEndDate_ValidEndDate_ShouldUpdateEndDate()
        {
            // Arrange
            var initialEndDate = DateTime.Now;
            var auction = new Auction(1, new Member(1, "Auctioneer", "LastName", "Address", "City", "12345", "Country", 1, "email@example.com", DateTime.Now, DateTime.Now, "1234567890"), "Name", "Description", DateTime.Now, initialEndDate);
            var newEndDate = initialEndDate.AddDays(1);

            // Act
            auction.SetEndDate(newEndDate);

            // Assert
            Assert.AreEqual(newEndDate, auction.GetEndDate());
        }
    }
}