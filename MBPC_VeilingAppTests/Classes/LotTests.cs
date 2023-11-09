using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MBPC_VeilingApp.Classes.Tests
{
    [TestClass()]
    public class LotTests
    {
        [TestMethod]
        public void SetAuctionId_ValidAuctionId_ShouldUpdateAuctionId()
        {
            // Arrange
            var member = new Member(1, "FirstName", "LastName", "Address", "City", "12345", "Country", 1, "email@example.com", DateTime.Now, DateTime.Now, "1234567890");
            var auction = new Auction(1, member, "AucName", "AuctionDescription", DateTime.Now, DateTime.Now.AddHours(1));
            var booklet = new Booklet(1, "BookName", "BookPane", "BookletDescription");
            var lot = new Lot(1, auction, member, booklet, 1, "LotDescription", "PerfType", "PerfCond", 1, 100.0m, "MemberRef");

            var newAuctionId = new Auction(2, member, "NAucName", "NewAuctionDescription", DateTime.Now, DateTime.Now.AddHours(2));

            // Act
            lot.SetAuctionId(newAuctionId);

            // Assert
            Assert.AreEqual(newAuctionId, lot.GetAuctionId());
        }

        [TestMethod]
        public void SetVendorId_ValidVendorId_ShouldUpdateVendorId()
        {
            // Arrange
            var member = new Member(1, "FirstName", "LastName", "Address", "City", "12345", "Country", 1, "email@example.com", DateTime.Now, DateTime.Now, "1234567890");
            var auction = new Auction(1, member, "AucName", "AuctionDescription", DateTime.Now, DateTime.Now.AddHours(1));
            var booklet = new Booklet(1, "BookName", "BookPane", "BookletDescription");
            var lot = new Lot(1, auction, member, booklet, 1, "LotDescription", "PerfType", "PerfCond", 1, 100.0m, "MemberRef");

            var newVendorId = new Member(2, "NewFirstName", "NewLastName", "NewAddress", "NewCity", "54321", "NewCountry", 2, "newemail@example.com", DateTime.Now, DateTime.Now, "987654321");

            // Act
            lot.SetVendorId(newVendorId);

            // Assert
            Assert.AreEqual(newVendorId, lot.GetVendorId());
        }

        [TestMethod]
        public void SetBookletId_ValidBookletId_ShouldUpdateBookletId()
        {
            // Arrange
            var member = new Member(1, "FirstName", "LastName", "Address", "City", "12345", "Country", 1, "email@example.com", DateTime.Now, DateTime.Now, "1234567890");
            var auction = new Auction(1, member, "AucName", "AuctionDescription", DateTime.Now, DateTime.Now.AddHours(1));
            var booklet = new Booklet(1, "BookName", "BookPane", "BookletDescription");
            var lot = new Lot(1, auction, member, booklet, 1, "LotDescription", "PerfType", "PerfCond", 1, 100.0m, "MemberRef");

            var newBookletId = new Booklet(2, "NBookName", "NBookPane", "NewBookletDescription");

            // Act
            lot.SetBookletId(newBookletId);

            // Assert
            Assert.AreEqual(newBookletId, lot.GetBookletId());
        }

        [TestMethod]
        public void SetLotNumber_ValidLotNumber_ShouldUpdateLotNumber()
        {
            // Arrange
            var member = new Member(1, "FirstName", "LastName", "Address", "City", "12345", "Country", 1, "email@example.com", DateTime.Now, DateTime.Now, "1234567890");
            var auction = new Auction(1, member, "AucName", "AuctionDescription", DateTime.Now, DateTime.Now.AddHours(1));
            var booklet = new Booklet(1, "BookName", "BookPane", "BookletDescription");
            var lot = new Lot(1, auction, member, booklet, 1, "LotDescription", "PerfType", "PerfCond", 1, 100.0m, "MemberRef");

            var newLotNumber = 2;

            // Act
            lot.SetLotNumber(newLotNumber);

            // Assert
            Assert.AreEqual(newLotNumber, lot.GetLotNumber());
        }

        [TestMethod]
        public void SetMemberReference_ValidMemberReference_ShouldUpdateMemberReference()
        {
            // Arrange
            var member = new Member(1, "FirstName", "LastName", "Address", "City", "12345", "Country", 1, "email@example.com", DateTime.Now, DateTime.Now, "1234567890");
            var auction = new Auction(1, member, "AucName", "AuctionDescription", DateTime.Now, DateTime.Now.AddHours(1));
            var booklet = new Booklet(1, "BookName", "BookPane", "BookletDescription");
            var lot = new Lot(1, auction, member, booklet, 1, "LotDescription", "PerfType", "PerfCond", 1, 100.0m, "MemberRef");

            var newMemberReference = "NewMemberRef";

            // Act
            lot.SetMemberReference(newMemberReference);

            // Assert
            Assert.AreEqual(newMemberReference, lot.GetMemberReference());
        }

        [TestMethod]
        public void SetDescription_ValidDescription_ShouldUpdateDescription()
        {
            // Arrange
            var member = new Member(1, "FirstName", "LastName", "Address", "City", "12345", "Country", 1, "email@example.com", DateTime.Now, DateTime.Now, "1234567890");
            var auction = new Auction(1, member, "AucName", "AuctionDescription", DateTime.Now, DateTime.Now.AddHours(1));
            var booklet = new Booklet(1, "BookName", "BookPane", "BookletDescription");
            var lot = new Lot(1, auction, member, booklet, 1, "LotDescription", "PerfType", "PerfCond", 1, 100.0m, "MemberRef");

            var newDescription = "NewDescription";

            // Act
            lot.SetDescription(newDescription);

            // Assert
            Assert.AreEqual(newDescription, lot.GetDescription());
        }

        [TestMethod]
        public void SetPerfType_ValidPerfType_ShouldUpdatePerfType()
        {
            // Arrange
            var member = new Member(1, "FirstName", "LastName", "Address", "City", "12345", "Country", 1, "email@example.com", DateTime.Now, DateTime.Now, "1234567890");
            var auction = new Auction(1, member, "AucName", "AuctionDescription", DateTime.Now, DateTime.Now.AddHours(1));
            var booklet = new Booklet(1, "BookName", "BookPane", "BookletDescription");
            var lot = new Lot(1, auction, member, booklet, 1, "LotDescription", "PerfType", "PerfCond", 1, 100.0m, "MemberRef");

            var newPerfType = "NewPerfType";

            // Act
            lot.SetPerfType(newPerfType);

            // Assert
            Assert.AreEqual(newPerfType, lot.GetPerfType());
        }

        [TestMethod]
        public void SetPerfCondition_ValidPerfCondition_ShouldUpdatePerfCondition()
        {
            // Arrange
            var member = new Member(1, "FirstName", "LastName", "Address", "City", "12345", "Country", 1, "email@example.com", DateTime.Now, DateTime.Now, "1234567890");
            var auction = new Auction(1, member, "AucName", "AuctionDescription", DateTime.Now, DateTime.Now.AddHours(1));
            var booklet = new Booklet(1, "BookName", "BookPane", "BookletDescription");
            var lot = new Lot(1, auction, member, booklet, 1, "LotDescription", "PerfType", "PerfCond", 1, 100.0m, "MemberRef");

            var newPerfCondition = "NewPerfCondition";

            // Act
            lot.SetPerfCondition(newPerfCondition);

            // Assert
            Assert.AreEqual(newPerfCondition, lot.GetPerfCondition());
        }

        [TestMethod]
        public void SetVerified_ValidVerified_ShouldUpdateVerified()
        {
            // Arrange
            var member = new Member(1, "FirstName", "LastName", "Address", "City", "12345", "Country", 1, "email@example.com", DateTime.Now, DateTime.Now, "1234567890");
            var auction = new Auction(1, member, "AucName", "AuctionDescription", DateTime.Now, DateTime.Now.AddHours(1));
            var booklet = new Booklet(1, "BookName", "BookPane", "BookletDescription");
            var lot = new Lot(1, auction, member, booklet, 1, "LotDescription", "PerfType", "PerfCond", 1, 100.0m, "MemberRef");

            var newVerified = 2;

            // Act
            lot.SetVerified(newVerified);

            // Assert
            Assert.AreEqual(newVerified, lot.GetVerified());
        }

        [TestMethod]
        public void SetReservePrice_ValidReservePrice_ShouldUpdateReservePrice()
        {
            // Arrange
            var member = new Member(1, "FirstName", "LastName", "Address", "City", "12345", "Country", 1, "email@example.com", DateTime.Now, DateTime.Now, "1234567890");
            var auction = new Auction(1, member, "AucName", "AuctionDescription", DateTime.Now, DateTime.Now.AddHours(1));
            var booklet = new Booklet(1, "BookName", "BookPane", "BookletDescription");
            var lot = new Lot(1, auction, member, booklet, 1, "LotDescription", "PerfType", "PerfCond", 1, 100.0m, "MemberRef");

            var newReservePrice = 150.0m;

            // Act
            lot.SetReservePrice(newReservePrice);

            // Assert
            Assert.AreEqual(newReservePrice, lot.GetReservePrice());
        }
    }
}