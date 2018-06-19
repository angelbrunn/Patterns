using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice inv = new Invoice();

            inv.GrossAmmount = 100;
            inv.NetPayableCalculator = new LocalPayable();
            System.Console.WriteLine("When Calculator is Local");
            System.Console.WriteLine(inv.NetAmount.ToString());
            inv.NetPayableCalculator = new IntlPayable();
            System.Console.WriteLine("When Calculator is International");
            System.Console.WriteLine(inv.NetAmount.ToString());
        }
    }
}
