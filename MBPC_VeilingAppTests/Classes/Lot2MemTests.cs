using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MBPC_VeilingApp.Classes.Tests
{
    [TestClass()]
    public class Lot2MemTests
    {
        [TestMethod]
        public void SetBuyerId_ValidBuyerId_ShouldUpdateBuyerId()
        {
            // Arrange
            var member = new Member(1, "FirstName", "LastName", "Address", "City", "12345", "Country", 1, "email@example.com", DateTime.Now, DateTime.Now, "1234567890");
            var auction = new Auction(1, member, "AucName", "AuctionDescription", DateTime.Now, DateTime.Now.AddHours(1));
            var booklet = new Booklet(1, "BookName", "BookPane", "BookletDescription");
            var lot = new Lot(1, auction, member, booklet, 1, "LotDescription", "PerfType", "PerfCond", 1, 100.0m, "MemberRef");
            var lot2Mem = new Lot2Mem(member, lot, DateTime.Now, 50.0m);

            var newBuyerId = new Member(2, "NewFirstName", "NewLastName", "NewAddress", "NewCity", "54321", "NewCountry", 2, "newemail@example.com", DateTime.Now, DateTime.Now, "987654321");

            // Act
            lot2Mem.SetBuyerId(newBuyerId);

            // Assert
            Assert.AreEqual(newBuyerId, lot2Mem.GetBuyerId());
        }

        [TestMethod]
        public void SetLotId_ValidLotId_ShouldUpdateLotId()
        {
            // Arrange
            var member = new Member(1, "FirstName", "LastName", "Address", "City", "12345", "Country", 1, "email@example.com", DateTime.Now, DateTime.Now, "1234567890");
            var auction = new Auction(1, member, "AucName", "AuctionDescription", DateTime.Now, DateTime.Now.AddHours(1));
            var booklet = new Booklet(1, "BookName", "BookPane", "BookletDescription");
            var lot = new Lot(1, auction, member, booklet, 1, "LotDescription", "PerfType", "PerfCond", 1, 100.0m, "MemberRef");
            var lot2Mem = new Lot2Mem(member, lot, DateTime.Now, 50.0m);

            var newLotId = new Lot(2, auction, member, booklet, 2, "NewLotDescription", "NPerfType", "NPerfCond", 2, 150.0m, "NewMemRef");

            // Act
            lot2Mem.SetLotId(newLotId);

            // Assert
            Assert.AreEqual(newLotId, lot2Mem.GetLotId());
        }

        [TestMethod]
        public void SetTimeStamp_ValidTimeStamp_ShouldUpdateTimeStamp()
        {
            // Arrange
            var member = new Member(1, "FirstName", "LastName", "Address", "City", "12345", "Country", 1, "email@example.com", DateTime.Now, DateTime.Now, "1234567890");
            var auction = new Auction(1, member, "AucName", "AuctionDescription", DateTime.Now, DateTime.Now.AddHours(1));
            var booklet = new Booklet(1, "BookName", "BookPane", "BookletDescription");
            var lot = new Lot(1, auction, member, booklet, 1, "LotDescription", "PerfType", "PerfCond", 1, 100.0m, "MemberRef");
            var lot2Mem = new Lot2Mem(member, lot, DateTime.Now, 50.0m);

            var newTimeStamp = DateTime.Now.AddHours(-1);

            // Act
            lot2Mem.SetTimeStamp(newTimeStamp);

            // Assert
            Assert.AreEqual(newTimeStamp, lot2Mem.GetTimeStamp());
        }

        [TestMethod]
        public void SetPrice_ValidPrice_ShouldUpdatePrice()
        {
            // Arrange
            var member = new Member(1, "FirstName", "LastName", "Address", "City", "12345", "Country", 1, "email@example.com", DateTime.Now, DateTime.Now, "1234567890");
            var auction = new Auction(1, member, "AucName", "AuctionDescription", DateTime.Now, DateTime.Now.AddHours(1));
            var booklet = new Booklet(1, "BookName", "BookPane", "BookletDescription");
            var lot = new Lot(1, auction, member, booklet, 1, "LotDescription", "PerfType", "PerfCond", 1, 100.0m, "MemberRef");
            var lot2Mem = new Lot2Mem(member, lot, DateTime.Now, 50.0m);

            var newPrice = 75.0m;

            // Act
            lot2Mem.SetPrice(newPrice);

            // Assert
            Assert.AreEqual(newPrice, lot2Mem.GetPrice());
        }
    }
}
