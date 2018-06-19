using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Window w = null;

            System.Console.WriteLine("DrawRect for IconWindow");
            w = new IconWindow();
            w.DrawRect();

            System.Console.WriteLine("");
            System.Console.WriteLine("DrawRect for DialogWindow");
            w = new DialogWindow();
            w.DrawRect();
        }
    }
}

