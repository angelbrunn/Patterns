using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Setup context in a state
            Printer c = new Printer(new StateReady());

            // Complete print job
            c.Print();
            c.Print();
            c.Print();
            c.Print();

            c = new Printer(new StateReady());

            // Cancel after start
            c.Print();
            c.Cancel();

            c = new Printer(new StateReady());
            // Cancel in printing
            c.Print();
            c.Print();
            c.Cancel();


            // Wait for user
            Console.Read();
        }
    }
}
