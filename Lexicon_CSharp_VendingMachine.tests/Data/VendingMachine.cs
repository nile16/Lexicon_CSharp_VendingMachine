using System;
using Xunit;
using Vending_Machine.Data;
using Vending_Machine.Models;

namespace Lexicon_CSharp_VendingMachine.tests
{
    [Collection("VendingMachine")]
    public class Test_VendingMachine
    {
        [Fact]
        public void Test_Constructor()
        {
            //Arrange
            VendingMachine vendingMachine;

            // Act
            vendingMachine = new VendingMachine();

            //Assert
            Assert.Equal("", vendingMachine.EndTransaction());
        }

        [Fact]
        public void Test_ShowAll()
        {
            //Arrange
            VendingMachine vendingMachine = new VendingMachine();
            string productList;

            //Act
            productList = vendingMachine.ShowAll();

            //Assert
            Assert.Equal("0, Apple, 12 kr\n1, Apple, 12 kr\n2, Apple, 12 kr\n3, Milk, 9 kr\n4, Milk, 9 kr\n5, Gloves, 25 kr\n6, Gloves, 25 kr\n", productList);
        }

        [Fact]
        public void Test_InsertMoney()
        {
            //Arrange
            VendingMachine vendingMachine = new VendingMachine();
            string insertResult1, insertResult2, insertResult3, insertResult4, insertResult5;

            //Act
            insertResult1 = vendingMachine.InsertMoney(100);
            insertResult2 = vendingMachine.InsertMoney(5);
            insertResult3 = vendingMachine.InsertMoney(2);
            insertResult4 = vendingMachine.InsertMoney(0);
            insertResult5 = vendingMachine.InsertMoney(-1);

            //Assert
            Assert.Equal("New Credit: 100 kr", insertResult1);
            Assert.Equal("New Credit: 105 kr", insertResult2);
            Assert.Equal("Denomination not accepted", insertResult3);
            Assert.Equal("Denomination not accepted", insertResult4);
            Assert.Equal("Denomination not accepted", insertResult5);
        }

        [Fact]
        public void Test_Purchase()
        {
            //Arrange
            VendingMachine vendingMachine = new VendingMachine();
            Product purchase1, purchase2, purchase3;
            int productsRemaining;
            
            vendingMachine.InsertMoney(10);

            //Act
            purchase1 = vendingMachine.Purchase(2);    //Too expensive
            purchase2 = vendingMachine.Purchase(999);  //Invalid selection
            purchase3 = vendingMachine.Purchase(3);

            //Assert
            productsRemaining = vendingMachine.ShowAll().Split('\n').Length - 1;
            Assert.Null(purchase1);
            Assert.Null(purchase2);
            Assert.Equal("Milk, 9 kr", purchase3.Examine());
            Assert.Equal("The milk is drunk", purchase3.Use());
            Assert.Equal(6, productsRemaining);
        }

        [Fact]
        public void Test_EndTransaction()
        {
            //Arrange
            VendingMachine vendingMachine = new VendingMachine();
            string changeBack;

            vendingMachine.InsertMoney(100);
            vendingMachine.Purchase(2);

            //Act
            changeBack = vendingMachine.EndTransaction();

            //Assert
            Assert.Equal("50kr 1pc\n20kr 1pc\n10kr 1pc\n5kr 1pc\n1kr 3pc\n", changeBack);
        }
    }
}