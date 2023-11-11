using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MBPC_VeilingApp.Classes.Tests
{
    [TestClass()]
    public class MemberTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SetFirstName_TooLong_ShouldThrowArgumentException()
        {
            // Arrange/Act
            var member = new Member(1, "FirstNameTooLong12345678901234567890123456789012345678901234567890", "LastName", "Address", "City", "12345", "Country", 1, "email@example.com", DateTime.Now, DateTime.Now, "1234567890");

            // Assert is handled by ExpectedException
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SetLastName_TooLong_ShouldThrowArgumentException()
        {
            // Arrange/Act
            var member = new Member(1, "FirstName", "LastNameTooLong12345678901234567890123456789012345678901234567890", "Address", "City", "12345", "Country", 1, "email@example.com", DateTime.Now, DateTime.Now, "1234567890");

            // Assert is handled by ExpectedException
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SetAddress_TooLong_ShouldThrowArgumentException()
        {
            // Arrange/Act
            var member = new Member(1, "FirstName", "LastName", "AddressTooLong12345678901234567890123456789012345678901234567890", "City", "12345", "Country", 1, "email@example.com", DateTime.Now, DateTime.Now, "1234567890");

            // Assert is handled by ExpectedException
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SetCity_TooLong_ShouldThrowArgumentException()
        {
            // Arrange/Act
            var member = new Member(1, "FirstName", "LastName", "Address", "CityTooLong12345678901234567890123456789012345678901234567890", "12345", "Country", 1, "email@example.com", DateTime.Now, DateTime.Now, "1234567890");

            // Assert is handled by ExpectedException
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SetZipCode_TooLong_ShouldThrowArgumentException()
        {
            // Arrange/Act
            var member = new Member(1, "FirstName", "LastName", "Address", "City", "12345678901234567890", "Country", 1, "email@example.com", DateTime.Now, DateTime.Now, "1234567890");

            // Assert is handled by ExpectedException
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SetCountry_TooLong_ShouldThrowArgumentException()
        {
            // Arrange/Act
            var member = new Member(1, "FirstName", "LastName", "Address", "City", "12345", "CountryTooLong12345678901234567890123456789012345678901234567890", 1, "email@example.com", DateTime.Now, DateTime.Now, "1234567890");

            // Assert is handled by ExpectedException
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SetEmail_TooLong_ShouldThrowArgumentException()
        {
            // Arrange/Act
            var member = new Member(1, "FirstName", "LastName", "Address", "City", "12345", "Country", 1, "emailTooLong@example.com123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890", DateTime.Now, DateTime.Now, "1234567890");

            // Assert is handled by ExpectedException
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SetTelephoneNumber_TooLong_ShouldThrowArgumentException()
        {
            // Arrange/Act
            var member = new Member(1, "FirstName", "LastName", "Address", "City", "12345", "Country", 1, "email@example.com", DateTime.Now, DateTime.Now, "12345678901234567890");

            // Assert is handled by ExpectedException
        }

        [TestMethod]
        public void SetFirstName_ValidFirstName_ShouldUpdateFirstName()
        {
            // Arrange
            var member = new Member(1, "InitialFirstName", "LastName", "Address", "City", "12345", "Country", 1, "email@example.com", DateTime.Now, DateTime.Now, "1234567890");
            var newFirstName = "NewFirstName";

            // Act
            member.SetFirstName(newFirstName);

            // Assert
            Assert.AreEqual(newFirstName, member.GetFirstName());
        }

        [TestMethod]
        public void SetLastName_ValidLastName_ShouldUpdateLastName()
        {
            // Arrange
            var member = new Member(1, "FirstName", "InitialLastName", "Address", "City", "12345", "Country", 1, "email@example.com", DateTime.Now, DateTime.Now, "1234567890");
            var newLastName = "NewLastName";

            // Act
            member.SetLastName(newLastName);

            // Assert
            Assert.AreEqual(newLastName, member.GetLastName());
        }

        [TestMethod]
        public void SetAddress_ValidAddress_ShouldUpdateAddress()
        {
            // Arrange
            var member = new Member(1, "FirstName", "LastName", "InitialAddress", "City", "12345", "Country", 1, "email@example.com", DateTime.Now, DateTime.Now, "1234567890");
            var newAddress = "NewAddress";

            // Act
            member.SetAddress(newAddress);

            // Assert
            Assert.AreEqual(newAddress, member.GetAddress());
        }

        [TestMethod]
        public void SetCity_ValidCity_ShouldUpdateCity()
        {
            // Arrange
            var member = new Member(1, "FirstName", "LastName", "Address", "InitialCity", "12345", "Country", 1, "email@example.com", DateTime.Now, DateTime.Now, "1234567890");
            var newCity = "NewCity";

            // Act
            member.SetCity(newCity);

            // Assert
            Assert.AreEqual(newCity, member.GetCity());
        }

        [TestMethod]
        public void SetZipCode_ValidZipCode_ShouldUpdateZipCode()
        {
            // Arrange
            var member = new Member(1, "FirstName", "LastName", "Address", "City", "12345", "Country", 1, "email@example.com", DateTime.Now, DateTime.Now, "1234567890");
            var newZipCode = "54321";

            // Act
            member.SetZipCode(newZipCode);

            // Assert
            Assert.AreEqual(newZipCode, member.GetZipCode());
        }

        [TestMethod]
        public void SetCountry_ValidCountry_ShouldUpdateCountry()
        {
            // Arrange
            var member = new Member(1, "FirstName", "LastName", "Address", "City", "12345", "InitialCountry", 1, "email@example.com", DateTime.Now, DateTime.Now, "1234567890");
            var newCountry = "NewCountry";

            // Act
            member.SetCountry(newCountry);

            // Assert
            Assert.AreEqual(newCountry, member.GetCountry());
        }

        [TestMethod]
        public void SetEmail_ValidEmail_ShouldUpdateEmail()
        {
            // Arrange
            var member = new Member(1, "FirstName", "LastName", "Address", "City", "12345", "Country", 1, "initial@email.com", DateTime.Now, DateTime.Now, "1234567890");
            var newEmail = "newemail@example.com";

            // Act
            member.SetEmail(newEmail);

            // Assert
            Assert.AreEqual(newEmail, member.GetEmail());
        }

        [TestMethod]
        public void SetTelephoneNumber_ValidTelephoneNumber_ShouldUpdateTelephoneNumber()
        {
            // Arrange
            var member = new Member(1, "FirstName", "LastName", "Address", "City", "12345", "Country", 1, "email@example.com", DateTime.Now, DateTime.Now, "1234567890");
            var newTelephoneNumber = "987654321";

            // Act
            member.SetTelephoneNumber(newTelephoneNumber);

            // Assert
            Assert.AreEqual(newTelephoneNumber, member.GetTelephoneNumber());
        }

        [TestMethod]
        public void SetBirthDate_ValidBirthDate_ShouldUpdateBirthDate()
        {
            // Arrange
            var initialBirthDate = DateTime.Now;
            var member = new Member(1, "FirstName", "LastName", "Address", "City", "12345", "Country", 1, "email@example.com", initialBirthDate, DateTime.Now, "1234567890");
            var newBirthDate = initialBirthDate.AddYears(-25);

            // Act
            member.SetBirthDate(newBirthDate);

            // Assert
            Assert.AreEqual(newBirthDate, member.GetBirthDate());
        }

        [TestMethod]
        public void SetMemberDate_ValidMemberDate_ShouldUpdateMemberDate()
        {
            // Arrange
            var initialMemberDate = DateTime.Now;
            var member = new Member(1, "FirstName", "LastName", "Address", "City", "12345", "Country", 1, "email@example.com", DateTime.Now, initialMemberDate, "1234567890");
            var newMemberDate = initialMemberDate.AddYears(-5);

            // Act
            member.SetMemberDate(newMemberDate);

            // Assert
            Assert.AreEqual(newMemberDate, member.GetMemberDate());
        }
    }
}