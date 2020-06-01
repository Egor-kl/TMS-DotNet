using calculator;
using System;
using Xunit;

namespace CalculatorApp.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void Summ_SummationTwoNumbers_ReturnResult()
        {
            //Arrange
            var result = 10;
            //Act
            var actual = Calculator.Summ(4,6);
            //Assert
            Assert.Equal(result, actual);
        }
        [Fact]
        public void Difference_DifferenceTwoNumbers_ReturnResult()
        {
            //Arrange
            var result = 20;
            //Act
            var actual = Calculator.Difference(30, 10);
            //Assert
            Assert.Equal(result, actual);
        }
        [Fact]
        public void Division_DivisionTwoNumbers_ReturnResult()
        {
            //Arrange
            var result = 12;
            //Act
            var actual = Calculator.Division(24, 2);
            //Assert
            Assert.Equal(result, actual);
        }
        [Fact]
        public void Product_MultiplicationTwoNumbers_ReturnResult()
        {
            //Arrange
            var result = 25;
            //Act
            var actual = Calculator.Product(5, 5);
            //Assert
            Assert.Equal(result, actual);
        }
    }
}
