using System;
using System.Collections.Generic;
using System.Text;

namespace Vending_Machine.Models
{
    public class Apple : Product
    {
        public Apple() : base(12) { }

        public override string Examine()
        {
            return $"Apple, {price} kr";
        }

        public override string Use()
        {
            return "The apple is eaten";
        }
    }
}
