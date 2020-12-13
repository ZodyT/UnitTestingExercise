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
            var add = new Add();

            //Act
            var actual = num1 + num2 + num3;

            //Assert
            Asset.Equal(expected, actual);
        }

        [Theory]
        [InlineData()]
        public void Subtract(int minuend, int subtrhend, int expected)
        {
            //Arrange

            //Act

            //Assert

        }

        [Theory]
        [InlineData()]
        public void Multiply(int num1, int num2, int expected)
        {
            //Arrange

            //Act

            //Assert

        }

        [Theory]
        [InlineData()]
        public void Divide(int num1, int num2, int expected)
        {
            //Arrange

            //Act

            //Assert

        }

        [Fact]
        public void YourMethodName()
        {
            //Arrange

            //Act

            //Assert

        }

        [Fact]
        public void YourMethodName2()
        {
            //Arrange

            //Act

            //Assert
        }
    }
}
