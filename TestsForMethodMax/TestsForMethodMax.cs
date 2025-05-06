namespace TestsForMethodMax
{
    [TestClass]
    public class TestsForMethodMax
    {
        [TestMethod]
        public void Max_ShouldReturnGreaterInt()
        {
            // Arrange
            int a = 5;
            int b = 10;
    
            // Act
            int result = ComparisonUtils.Max(a, b);

            // Assert
            Assert.AreEqual(10, result);
        }

        [TestMethod]
        public void Max_ShouldReturnGreaterString()
        {
            // Arrange
            string s1 = "apple";
            string s2 = "banana";

            // Act
            string result = ComparisonUtils.Max(s1, s2);

            // Assert
            Assert.AreEqual("banana", result);
        }

        [TestMethod]
        public void Max_ShouldReturnGreaterDateTime()
        {
            // Arrange
            DateTime dt1 = new DateTime(2023, 1, 1);
            DateTime dt2 = new DateTime(2023, 1, 2);

            // Act
            DateTime result = ComparisonUtils.Max(dt1, dt2);

            // Assert
            Assert.AreEqual(dt2, result);
        }

        [TestMethod]
        public void Max_ShouldHandleEqualValues()
        {
            // Arrange
            double d1 = 3.14;
            double d2 = 3.14;

            // Act
            double result = ComparisonUtils.Max(d1, d2);

            // Assert
            Assert.AreEqual(3.14, result);
        }

        [TestMethod]
        public void Max_ShouldWorkWithArrayOfInts()
        {
            // Arrange
            int[] values = { 1, 5, 3, 9, 2 };

            // Act
            int result = ComparisonUtils.Max(values);

            // Assert
            Assert.AreEqual(9, result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Max_ShouldThrowOnEmptyArray()
        {
            // Arrange
            int[] values = Array.Empty<int>();

            // Act & Assert
            ComparisonUtils.Max(values);
        }

        [TestMethod]
        public void Max_ShouldWorkWithCustomComparableType()
        {
            // Arrange
            var p1 = new Person("Alice", 25);
            var p2 = new Person("Bob", 30);

            // Act
            var result = ComparisonUtils.Max(p1, p2);

            // Assert
            Assert.AreEqual(p2, result);
        }

        private class Person : IComparable<Person>
        {
            public string Name { get; }
            public int Age { get; }

            public Person(string name, int age)
            {
                Name = name;
                Age = age;
            }

            public int CompareTo(Person other)
            {
                return Age.CompareTo(other.Age);
            }
        }
    }
}