using System;
using System.Collections.Generic;
using System.Text;

namespace Vending_Machine.Models
{
    public class Milk : Product
    {
        public Milk() : base (9) { }

        public override string Examine()
        {
            return $"Milk, {price} kr";
        }

        public override string Use()
        {
            return "The milk is drunk";
        }
    }
}
