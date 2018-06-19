using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern
{
    public abstract class Visitor
    {
        abstract public void VisitCircle(Circle circle);
        abstract public void VisitTrangle(Trangle trangle);
    }

    public abstract class Shape
    {
        abstract public void Accept(Visitor visitor);
    }

    public class Circle : Shape
    {
        public override void Accept(Visitor visitor)
        {
            visitor.VisitCircle(this);
        }
    }

    public class Trangle : Shape
    {
        public override void Accept(Visitor visitor)
        {
            visitor.VisitTrangle(this);
        }
    }
    public class DrawVisitor : Visitor
    {
        public override void VisitCircle(Circle circle)
        {
            Console.WriteLine("Drawing Circle");
        }

        public override void VisitTrangle(Trangle trangle)
        {
            Console.WriteLine("Drawing Trangle");
        }
    }
    public class ScaleVisitor : Visitor
    {
        public override void VisitCircle(Circle circle)
        {
            Console.WriteLine("Scaling Circle");
        }

        public override void VisitTrangle(Trangle trangle)
        {
            Console.WriteLine("Scaling Trangle");
        }
    }

}
