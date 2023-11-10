using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MBPC_VeilingApp.Classes.Tests
{
    [TestClass]
    public class BookletTests
    {

        //Test for datebase rules
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SetName_TooLong_ShouldThrowArgumentException()
        {
            // Arrange/Act
            var booklet = new Booklet(1, "NameTooLong123", "Pane", "Description");

            // Assert is handled by ExpectedException
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SetPane_TooLong_ShouldThrowArgumentException()
        {
            // Arrange/Act
            var booklet = new Booklet(1, "Name", "PaneTooLong123", "Description");

            // Assert is handled by ExpectedException
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SetDescription_TooLong_ShouldThrowArgumentException()
        {
            // Arrange/Act
            var booklet = new Booklet(1, "Name", "Pane", "This description is definitely way too long and should cause an exception to be thrown");

            // Assert is handled by ExpectedException
        }

        // Test Setters and Getters for Name
        [TestMethod]
        public void SetName_ValidName_ShouldUpdateName()
        {
            // Arrange
            var booklet = new Booklet(1, "Initial", "Pane", "Description");
            var newName = "NewName";

            // Act
            booklet.SetName(newName);

            // Assert
            Assert.AreEqual(newName, booklet.GetName());
        }

        // Test Setters and Getters for Pane
        [TestMethod]
        public void SetPane_ValidPane_ShouldUpdatePane()
        {
            // Arrange
            var booklet = new Booklet(1, "Name", "InitPane", "Description");
            var newPane = "NewPane";

            // Act
            booklet.SetPane(newPane);

            // Assert
            Assert.AreEqual(newPane, booklet.GetPane());
        }

        // Test Setters and Getters for Description
        [TestMethod]
        public void SetDescription_ValidDescription_ShouldUpdateDescription()
        {
            // Arrange
            var booklet = new Booklet(1, "Name", "Pane", "InitialDescription");
            var newDescription = "New Description";

            // Act
            booklet.SetDescription(newDescription);

            // Assert
            Assert.AreEqual(newDescription, booklet.GetDescription());
        }

        // Test Getters
        [TestMethod]
        public void GetId_ShouldReturnCorrectId()
        {
            // Arrange
            var bookletId = 1;
            var booklet = new Booklet(bookletId, "Name", "Pane", "Description");

            // Act
            var result = booklet.GetId();

            // Assert
            Assert.AreEqual(bookletId, result);
        }

        [TestMethod]
        public void GetName_ShouldReturnCorrectName()
        {
            // Arrange
            var name = "Name";
            var booklet = new Booklet(1, name, "Pane", "Description");

            // Act
            var result = booklet.GetName();

            // Assert
            Assert.AreEqual(name, result);
        }

        [TestMethod]
        public void GetPane_ShouldReturnCorrectPane()
        {
            // Arrange
            var pane = "Pane";
            var booklet = new Booklet(1, "Name", pane, "Description");

            // Act
            var result = booklet.GetPane();

            // Assert
            Assert.AreEqual(pane, result);
        }

        [TestMethod]
        public void GetDescription_ShouldReturnCorrectDescription()
        {
            // Arrange
            var description = "Description";
            var booklet = new Booklet(1, "Name", "Pane", description);

            // Act
            var result = booklet.GetDescription();

            // Assert
            Assert.AreEqual(description, result);
        }
    }
}