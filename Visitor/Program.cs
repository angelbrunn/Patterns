using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle();
            Trangle triangle = new Trangle();

            Visitor visitor = new DrawVisitor();

            circle.Accept(visitor);
            triangle.Accept(visitor);

            Visitor anotherVisitor = new ScaleVisitor();

            circle.Accept(anotherVisitor);
            triangle.Accept(anotherVisitor);

        }
    }
}
