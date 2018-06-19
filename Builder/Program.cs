using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create director and builders
            Waiter waiter = new Waiter();

            PizzaBuilder b1 = new CheesePizzaBuilder();
            PizzaBuilder b2 = new MixedPizzaBuilder();

            // Construct two products
            waiter.Serve(b1);

            Pizza p1 = b1.GetPizza();
            p1.Deliver();

            waiter.Serve(b2);
            Pizza p2 = b2.GetPizza();
            p2.Deliver();

            // Wait for user
            Console.Read();
        }
    }
}
