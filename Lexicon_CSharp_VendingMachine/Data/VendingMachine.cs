using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Vending_Machine.Models;

namespace Vending_Machine.Data
{
    public class VendingMachine : IVending
    {
        private int credit = 0;
        private readonly int[] denominations = new int[] { 1000, 500, 100, 50, 20, 10, 5, 1 };
        private Product[] products = new Product[] { new Apple(),
                                                            new Apple(),
                                                            new Apple(),
                                                            new Milk(),
                                                            new Milk(),
                                                            new Gloves(),
                                                            new Gloves() };

        public Product Purchase(int listIndex)
        {
            Product purchase;

            if (listIndex >= products.Length - 1 || listIndex < 0 || credit < products[listIndex].price)
            {
                return null;
            }

            purchase = products[listIndex];
            credit -= purchase.price;
            products = products.Where((p, i) => i != listIndex).ToArray();

            return purchase;
        }

        public string ShowAll()
        {
            string list = "";

            for (int i = 0; i < products.Length; i++)
            {
                list += $"{i}, {products[i].Examine()}\n";
            }

            return list;
        }

        public string InsertMoney(int amount)
        {
            if (!denominations.Contains(amount))
            {
                return "Denomination not accepted";

            }

            credit += amount;

            return $"New Credit: {credit} kr";
        }

        public string EndTransaction()
        {
            string change = "";

            foreach (int denomination in denominations)
            {
                int coins = credit / denomination;

                credit -= coins * denomination;
                if (coins > 0)
                {
                    change += ($"{denomination}kr {coins}pc\n");
                }
            }

            return change;
        }
    }
}
