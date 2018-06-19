using System.Collections;
using System.Collections.Generic;
using System;

namespace DesignPattern
{
    abstract class IShape
    {
        public abstract void Print();
    }

    class Rectangle : IShape
    {
        public override void Print()
        {
            Console.WriteLine("Printing Rectangle");
        }
    }

    class Circle : IShape
    {
        public override void Print()
        {
            Console.WriteLine("Printing Circle");
        }
    }

    class ShapeObjectFactory
    {
        Dictionary<string, IShape> shapes = new Dictionary<string, IShape>();
        
        public int TotalObjectsCreated
        {
            get { return shapes.Count; }
        }

        public IShape GetShape(string ShapeName)
        {
            IShape shape = null;
            if (shapes.ContainsKey(ShapeName))
            {
                shape = shapes[ShapeName];
            }
            else 
            {
                switch (ShapeName)
                {
                    case "Rectangle":
                        shape = new Rectangle();
                        shapes.Add("Rectangle", shape);
                        break;
                    case "Circle":
                        shape = new Circle();
                        shapes.Add("Circle", shape);
                        break;
                    default:
                        throw new Exception("Factory cannot create the object specified");
                }
            }
            return shape;
        }
    }
}