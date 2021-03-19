using System;

namespace Vending_Machine.Data
{
    class Program
    {
        static void Main()
        {
            VendingMachine vendingMachine = new VendingMachine();
            
            Console.WriteLine(vendingMachine.ShowAll());
            Console.WriteLine(vendingMachine.InsertMoney(100));
            Console.WriteLine(vendingMachine.Purchase(2).Use());
            Console.WriteLine(vendingMachine.EndTransaction());

        }
    }
}
