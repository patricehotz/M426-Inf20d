using System;
using Xunit;
using Xunit.Sdk;

namespace Calculator.Tests
{
    public class CalculatorTest
    {
        [Fact]
        public void TestAddThreeToTwoPIsFive()
        {
            // Arrange
            int a = 2;
            int b = 3;
            int expected = 5;
            Calculator calculator = new Calculator();

            // Act
            int actual = calculator.Add(a, b);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestSubtractFourFromSixIsTwo()
        {
            // Given
            int a = 6;
            int b = 4;
            int expected = 2;
            Calculator calculator = new Calculator();

            // When
            int actual = calculator.Subtract(a, b);

            // Then
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestMultiplyFourTimesSixIsTwentyFour()
        {
            //Arrange
            var a = 4;
            var b = 6;
            var expected = 24;
            var calculater = new Calculator();
            
            //Act
            var actual = calculater.Multiply(a, b);
            
            //Assert
            Assert.Equal(expected, actual);
        }
        
        [Fact]
        public void TestTenDividedByFiveIsTwo()
        {
            //Arrange
            const int a = 10;
            const int b = 5;
            const int expected = 2;
            var calculater = new Calculator();
            
            //Act
            var actual = calculater.Divide(a, b);
            
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void DividedByZero()
        {
            //Arrange
            const int a = 10;
            const int b = 0;
            var calculator = new Calculator();
            
            //Assert
            Assert.Throws<ArgumentException>(() => calculator.Divide(a, b));
        }
    }
}
