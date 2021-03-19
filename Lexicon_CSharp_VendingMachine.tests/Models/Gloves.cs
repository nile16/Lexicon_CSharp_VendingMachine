using System;
using Xunit;
using Vending_Machine.Models;

namespace Lexicon_CSharp_VendingMachine.tests
{
    [Collection("VendingMachine")]
    public class Test_Gloves
    {
        [Fact]
        public void Test_Constructor()
        {
            //Arrange
            Gloves gloves;

            // Act
            gloves = new Gloves();

            //Assert
            Assert.Equal(25, gloves.price);
        }

        [Fact]
        public void Test_Examine()
        {
            //Arrange
            Gloves gloves = new Gloves();
            string result;

            // Act
            result = gloves.Examine();

            //Assert
            Assert.Equal("Gloves, 25 kr", result);
        }

        [Fact]
        public void Test_Use()
        {
            //Arrange
            Gloves gloves = new Gloves();
            string result;

            // Act
            result = gloves.Use();

            //Assert
            Assert.Equal("The gloves are worn", result);
        }
    }
}
