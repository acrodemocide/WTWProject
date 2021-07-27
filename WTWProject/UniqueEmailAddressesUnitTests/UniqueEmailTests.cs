using Microsoft.VisualStudio.TestTools.UnitTesting;
using WTWProject;

namespace UniqueEmailAddressesUnitTests
{
    [TestClass]
    public class UniqueEmailTests
    {
        [TestMethod]
        public void SingleEmail_ReturnsCountOfOne()
        {
            // Arrange
            var expectedCount = 1;
            string[] emails = { "easyEmail@example.com" };

            // Act
            var actualCount = Program.NumberOfUniqueEmailAddresses(emails);

            // Assert
            Assert.AreEqual(expectedCount, actualCount);
        }

        [TestMethod]
        public void DifferentLocal_DifferentDomains_ReturnsCountOfTwo()
        {
            // Arrange
            var expectedCount = 2;
            string[] emails = { "easyEmail@example.com", "easyEmail@notExample.com" };

            // Act
            var actualCount = Program.NumberOfUniqueEmailAddresses(emails);

            // Assert
            Assert.AreEqual(expectedCount, actualCount);
        }

        [TestMethod]
        public void SameLocal_SameDomain_ReturnCountOfOne()
        {
            // Arrange
            var expectedCount = 1;
            string[] emails = { "easyEmail@example.com", "easyEmail@example.com" };

            // Act
            var actualCount = Program.NumberOfUniqueEmailAddresses(emails);

            // Assert
            Assert.AreEqual(expectedCount, actualCount);
        }

        [TestMethod]
        public void SameLocal_DifferentAfterPlus_SameDomain_ReturnsCountOfOne()
        {
            // Arrange
            var expectedCount = 1;
            string[] emails = { "easyEmail+1@example.com", "easyEmail+321@example.com" };

            // Act
            var actualCount = Program.NumberOfUniqueEmailAddresses(emails);

            // Assert
            Assert.AreEqual(expectedCount, actualCount);
        }

        [TestMethod]
        public void DifferentLocal_SameAfterPlus_SameDomain_ReturnsCountOfTwo()
        {
            // Arrange
            var expectedCount = 2;
            string[] emails = { "easyEmail+321@example.com", "otherEmail+321@example.com" };

            // Act
            var actualCount = Program.NumberOfUniqueEmailAddresses(emails);

            // Assert
            Assert.AreEqual(expectedCount, actualCount);
        }

        [TestMethod]
        public void SameLocal_OneWithDecimals_SameDomain_ReturnsCountOfOne()
        {
            // Arrange
            var expectedCount = 1;
            string[] emails = { "otherEmail@example.com", "o.th.er.Ema.il@example.com" };

            // Act
            var actualCount = Program.NumberOfUniqueEmailAddresses(emails);

            // Assert
            Assert.AreEqual(expectedCount, actualCount);
        }

        [TestMethod]
        public void SameLocal_OneWithDecimals_DifferentAfterPlus_SameDomain_ReturnsCountOfOne()
        {
            // Arrange
            var expectedCount = 1;
            string[] emails = { "otherEmail+3748926@example.com", "o.th.er.Ema.il+asdf1234@example.com" };

            // Act
            var actualCount = Program.NumberOfUniqueEmailAddresses(emails);

            // Assert
            Assert.AreEqual(expectedCount, actualCount);
        }
    }
}
