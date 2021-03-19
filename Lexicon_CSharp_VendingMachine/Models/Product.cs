using System;
using System.Collections.Generic;
using System.Text;

namespace Vending_Machine.Models
{
    public abstract class Product
    {
        public readonly int price;

        public Product(int price)
        {
            this.price = price;
        }

        public abstract string Examine();

        public abstract string Use();
    }
}
