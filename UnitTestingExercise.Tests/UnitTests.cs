using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(1, 1, 1, 3)]
        [InlineData(-1, -2, -3, -6)]
        [InlineData(0, 0, 0, 0)]
        public void Add(int num1, int num2, int num3, int expected)
        {
            //Arrange
            var addNum = new UnitTestMethods();

            //Act
            int actual = addNum.Add(num1, num2, num3);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1, 1, 0)]
        [InlineData(-1, 3, -4)]
        [InlineData(-1, -3, 2)]
        [InlineData(0, 0, 0)]
        public void Subtract(int minuend, int subtrhend, int expected)
        {
            //Arrange
            var subNum = new UnitTestMethods();

            //Act
            int actual = subNum.Subtract(minuend, subtrhend);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(1, 1, 1)]
        [InlineData(-1, 5, -5)]
        [InlineData(5, 0, 0)]
        [InlineData(0, 0, 0)]
        public void Multiply(int num1, int num2, int expected)
        {
            //Arrange
            var mulNum = new UnitTestMethods();

            //Act
            int actual = mulNum.Multiply(num1, num2);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5, 1, 5)]
        [InlineData(-25, 5, -5)]
        [InlineData(0, 5, 0)]
        public void Divide(int num1, int num2, int expected)
        {
            //Arrange
            var divSum = new UnitTestMethods();

            //Act
            int actual = divSum.Divide(num1, num2);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void DoStuff()
        {
            //Arrange
            var stuff = new UnitTestMethods();

            //Act
            string actual = stuff.DoStuff();

            //Assert
            Assert.Equal("Doing Stuff", actual);
        }

        [Fact]
        public void Greetings()
        {
            //Arrange
            var quote = new UnitTestMethods();

            //Act
            var actual = quote.Greetings();

            //Assert
            Assert.Equal("Hello there friend!", actual);
        }
    }
}
