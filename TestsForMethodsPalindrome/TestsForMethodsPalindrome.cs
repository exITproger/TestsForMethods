namespace TestsForMethodsPalindrome
{
    [TestClass]
    public class TestsForMethodsPalindrome
    {
        // Тесты для IsPalindrome
        [TestMethod]
        public void IsPalindrome_IgnoresSpacesAndPunctuation()
        {
            Assert.IsTrue(PalindromeChecker.IsPalindrome("A man, a plan, a canal: Panama!"));
        }

        [TestMethod]
        public void IsPalindrome_WorksWithNumbers()
        {
            Assert.IsTrue(PalindromeChecker.IsPalindrome("12321"));
        }

        [TestMethod]
        public void IsPalindrome_ReturnsFalseForNonPalindromes()
        {
            Assert.IsFalse(PalindromeChecker.IsPalindrome("hello"));
        }

        [TestMethod]
        public void IsPalindrome_ReturnsFalseForEmptyString()
        {
            Assert.IsFalse(PalindromeChecker.IsPalindrome(""));
        }

        // Тесты для AreAllPalindromes
        [TestMethod]
        public void AreAllPalindromes_ReturnsTrueForAllPalindromes()
        {
            string[] palindromes = { "madam", "racecar", "121" };
            Assert.IsTrue(PalindromeChecker.AreAllPalindromes(palindromes));
        }

        [TestMethod]
        public void AreAllPalindromes_ReturnsFalseIfOneIsNot()
        {
            string[] mixed = { "level", "world", "radar" };
            Assert.IsFalse(PalindromeChecker.AreAllPalindromes(mixed));
        }

        // Тесты для IsPalindromeObject
        [TestMethod]
        public void IsPalindromeObject_WorksWithIntegers()
        {
            Assert.IsTrue(PalindromeChecker.IsPalindromeObject(12321));
        }

        [TestMethod]
        public void IsPalindromeObject_ReturnsFalseForNonPalindromicObjects()
        {
            Assert.IsFalse(PalindromeChecker.IsPalindromeObject(DateTime.Now));
        }

        [TestMethod]
        public void IsPalindromeObject_HandlesNull()
        {
            Assert.IsFalse(PalindromeChecker.IsPalindromeObject(null));
        }
    }
}