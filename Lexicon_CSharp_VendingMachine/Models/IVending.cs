using System;
using System.Collections.Generic;
using System.Text;

namespace Vending_Machine.Models
{
    interface IVending
    {
        Product Purchase(int listIndex);
        string ShowAll();
        string InsertMoney(int amount);
        string EndTransaction();
    }
}
