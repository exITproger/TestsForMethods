using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace TestsForMethodFactorial
{
    [TestClass]
    public class TestsForMethodFactorial
    {
        [TestMethod]
        public void Factorial_ShouldReturnCorrectValue()
        {
            // Arrange
            int x = 5;
            int expected = 120;

            // Act
            int actual = Program.Factorial(x);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Factorial_ShouldThrowOnNegativeNumbers()
        {
            // Arrange
            int x = -5;

            // Act
            int actual = Program.Factorial(x);

            // Assert is handled by ExpectedException
        }

        [TestMethod]
        public void Factorial_ShouldHandleZero()
        {
            // Arrange
            int x = 0;
            int expected = 1;

            // Act
            int actual = Program.Factorial(x);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Factorial_ShouldHandleEdgeCases()
        {
            // Arrange
            int x = 1;
            int expected = 1;

            // Act
            int actual = Program.Factorial(x);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(OverflowException))]
        public void Factorial_ShouldThrowOnLargeNumbers()
        {
            // Arrange
            int x = 20; // This will overflow for int

            // Act
            int actual = Program.Factorial(x);

            // Assert is handled by ExpectedException
        }
    }
}
