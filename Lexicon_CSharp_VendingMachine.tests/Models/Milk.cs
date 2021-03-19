using System;
using Xunit;
using Vending_Machine.Models;

namespace Lexicon_CSharp_VendingMachine.tests
{
    [Collection("VendingMachine")]
    public class Test_Milk
    {
        [Fact]
        public void Test_Constructor()
        {
            //Arrange
            Milk milk;

            // Act
            milk = new Milk();

            //Assert
            Assert.Equal(9, milk.price);
        }

        [Fact]
        public void Test_Examine()
        {
            //Arrange
            Milk milk = new Milk();
            string result;

            // Act
            result = milk.Examine();

            //Assert
            Assert.Equal("Milk, 9 kr", result);
        }

        [Fact]
        public void Test_Use()
        {
            //Arrange
            Milk milk = new Milk();
            string result;

            // Act
            result = milk.Use();

            //Assert
            Assert.Equal("The milk is drunk", result);
        }
    }
}
