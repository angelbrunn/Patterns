using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcretePrototype p1 = new ConcretePrototype();
            Console.WriteLine("Instead of creating the object from scratch we take the prototype");
            ConcretePrototype c1 = (ConcretePrototype)p1.Create();

            // Wait for user
            Console.Read();
        }
    }
}
