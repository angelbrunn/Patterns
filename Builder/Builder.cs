using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace DesignPattern
{
    class Waiter
    {
        PizzaBuilder pizzabldr;

        // Builder uses a complex series of steps
        public void Serve(PizzaBuilder pizzaType)
        {
            pizzabldr = pizzaType;
            pizzabldr.BuildPizzaBase();
            pizzabldr.BuildToppings();
        }
    }

    abstract class PizzaBuilder
    {
        public abstract void BuildPizzaBase();
        public abstract void BuildToppings();
        public abstract Pizza GetPizza();
    }

    class CheesePizzaBuilder : PizzaBuilder
    {
        private Pizza product = new Pizza();

        public override void BuildPizzaBase()
        {
            product.Add("Base");
            Console.WriteLine("Adding Base for cheese pizza");
        }

        public override void BuildToppings()
        {
            product.Add("Topping : Cheese");
            Console.WriteLine("Adding topping for cheese pizza");
        }

        public override Pizza GetPizza()
        {
            return product;
        }
    }

    class MixedPizzaBuilder : PizzaBuilder
    {
        private Pizza product = new Pizza();

        public override void BuildPizzaBase()
        {
            product.Add("Base");
            Console.WriteLine("Adding Base for mixed pizza");
        }

        public override void BuildToppings()
        {
            Console.WriteLine("Adding topping fpr mixed pizza");
            product.Add("Topping : Onion");
            Console.WriteLine("Adding more topping for mixed pizza");
            product.Add("Topping : Tomato");
        }

        public override Pizza GetPizza()
        {
            return product;
        }

    }

    class Pizza
    {
        ArrayList parts = new ArrayList();

        public void Add(string part)
        {
            parts.Add(part);
        }

        public void Deliver()
        {
            Console.WriteLine("\nDelivering Pizza with the following");
            foreach (string part in parts)
                Console.WriteLine(" " + part);
            Console.WriteLine("");
        }
    }
}
