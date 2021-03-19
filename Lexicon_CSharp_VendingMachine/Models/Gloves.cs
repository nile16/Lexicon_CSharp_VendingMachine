using System;
using System.Collections.Generic;
using System.Text;

namespace Vending_Machine.Models
{
    public class Gloves : Product
    {
        public Gloves() : base(25) { }

        public override string Examine()
        {
            return $"Gloves, {price} kr";
        }

        public override string Use()
        {
            return "The gloves are worn";
        }
    }
}
