using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern
{
    abstract class Prototype
    {
        public abstract Prototype Create();
    }

    // A very heavy object which is time consuming object
    class ConcretePrototype : Prototype
    {
        public override Prototype Create()
        {
            Console.WriteLine("Creating an object from the existing object");
            return (Prototype)this.MemberwiseClone();
        }
    }
}
