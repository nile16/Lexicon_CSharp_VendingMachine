using System;
using Xunit;
using Vending_Machine.Models;

namespace Lexicon_CSharp_VendingMachine.tests
{
    [Collection("VendingMachine")]
    public class Test_Apple
    {
        [Fact]
        public void Test_Constructor()
        {
            //Arrange
            Apple apple;

            // Act
            apple = new Apple();

            //Assert
            Assert.Equal(12, apple.price);
        }

        [Fact]
        public void Test_Examine()
        {
            //Arrange
            Apple apple = new Apple();
            string result;

            // Act
            result = apple.Examine();

            //Assert
            Assert.Equal("Apple, 12 kr", result);
        }

        [Fact]
        public void Test_Use()
        {
            //Arrange
            Apple apple = new Apple();
            string result;

            // Act
            result = apple.Use();

            //Assert
            Assert.Equal("The apple is eaten", result);
        }
    }
}
