using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)]
        [InlineData(8, 9, 7, 24)]

        public void AddTest(int num1, int num2, int num3, int expected)
        {
            // Arrange
            var test = new Calculator();

            // Act
            var actual = test.Add(num1, num2, num3);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(8, 4, 4)]
        [InlineData(12, 4, 8)]
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            // Arrange
            var tester = new Calculator();

            // Act
            var actual = tester.Subtract(minuend, subtrhend);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5, 2, 10)]
        [InlineData(3, 6, 18)]
        public void MultiplyTest(int num1, int num2, int expected)
        {
            // Arrange
            var tester = new Calculator();

            // Act
            var actual = tester.Multiply(num1, num2);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10, 2, 5)]
        [InlineData(4,2,2)]
        public void DivideTest(int dividend, int divisor, int expected)
        {
            // Arrange
            var tester = new Calculator();

            // Act
            var actual = tester.Divide(dividend, divisor);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
