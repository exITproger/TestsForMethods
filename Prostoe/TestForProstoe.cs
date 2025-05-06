using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace Prostoe
{
    [TestClass]
    public class TestsForProstoe
    {
        [TestMethod]
        public void IsPrime_ShouldReturnFalseForOne()
        {
            // Arrange
            int number = 1;
            bool expected = false;

            // Act
            bool actual = Program.Prostoe(number);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Prostoe_ShouldReturnTrueForTwo()
        {
            // Arrange
            int number = 2;
            bool expected = true;

            // Act
            bool actual = Program.Prostoe(number);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Prostoe_ShouldReturnFalseForEvenNumber()
        {
            // Arrange
            int number = 4;
            bool expected = false;

            // Act
            bool actual = Program.Prostoe(number);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Prostoe_ShouldReturnTrueForPrimeNumber()
        {
            // Arrange
            int number = 17;
            bool expected = true;

            // Act
            bool actual = Program.Prostoe(number);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsPrime_ShouldReturnFalseForLargeNonPrime()
        {
            // Arrange
            int number = 999;
            bool expected = false;

            // Act
            bool actual = Program.Prostoe(number);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsPrime_ShouldReturnTrueForLargePrime()
        {
            // Arrange
            int number = 7919;
            bool expected = true;

            // Act
            bool actual = Program.Prostoe(number);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}