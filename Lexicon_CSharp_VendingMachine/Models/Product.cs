using System;
using System.Collections.Generic;
using System.Text;

namespace Vending_Machine.Models
{
    public abstract class Product
    {
        public int price;
        public string name;

        public Product(int price)
        {
            this.price = price;
        }

        public abstract string Examine();

        public abstract string Use();
    }
}
