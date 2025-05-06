using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace ProgramTests
{
    [TestClass]
    public class TestsForMethodSym
    {
        [TestMethod]
        public void Sym_ShouldReturnCorrectSum()
        {
            // Arrange
            int x = 5;
            int y = 10;
            int expected = 15;

            // Act
            int actual = Program.Sym(x, y);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Sym_ShouldHandleNegativeNumbers()
        {
            // Arrange
            int x = -5;
            int y = -10;
            int expected = -15;

            // Act
            int actual = Program.Sym(x, y);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Sym_ShouldHandleZero()
        {
            // Arrange
            int x = 0;
            int y = 0;
            int expected = 0;

            // Act
            int actual = Program.Sym(x, y);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Sym_ShouldHandleLargeNumbers()
        {
            // Arrange
            int x = int.MaxValue;
            int y = 1;
            // Note: This will cause overflow, which is expected behavior for this function
            int expected = int.MinValue; // because of integer overflow

            // Act
            int actual = Program.Sym(x, y);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}