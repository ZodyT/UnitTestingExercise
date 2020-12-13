using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(1, 2, 3, 6)]
        [InlineData(4, 5, 6, 15)]
        [InlineData(7, 8, 9, 24)]
        [InlineData(10, 11, 12, 33)]

        public void Add(int num1, int num2, int num3, int expected)
        {
            //Arrange
            var calculator= new UnitTestMethods();

            //Act
            var actual = calculator.Add(num1, num2, num3);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1, 2, -1)]
        [InlineData(24, 15, 9)]
        [InlineData(33, 45, -12)]
        [InlineData(50, 25, 25)]
        public void Subtract(int minuend, int subtrhend, int expected)
        {
            //Arrange
            var calculator = new UnitTestMethods();

            //Act
            var actual = calculator.Subtract(minuend, subtrhend);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(4, 5, 20)]
        [InlineData(7, 8, 56)]
        [InlineData(10, 11, 110)]
        public void Multiply(int num1, int num2, int expected)
        {
            //Arrange
            var calculator = new UnitTestMethods();

            //Act
            var actual = calculator.Multiply(num1, num2);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2, 2, 1)]
        [InlineData(20, 5, 4)]
        [InlineData(80, 10, 8)]
        [InlineData(100, 2, 50)]
        public void Divide(int num1, int num2, int expected)
        {
            //Arrange
            var calculator = new UnitTestMethods();

            //Act
            var actual = calculator.Divide(num1, num2);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
