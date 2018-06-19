using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern
{
    abstract class Document
    {
        public abstract void PrintHeader();
        public abstract void PrintBody();
        public abstract void PrintFooter();

        public void Print()
        {
            // Print algo is to print header body and then footer
            PrintHeader();
            PrintBody();
            PrintFooter();
        }
    }


    class XMLDocument : Document
    {
        public override void PrintHeader()
        {
            Console.WriteLine("XMLDocument.PrintHeader()");
        }
        public override void PrintBody()
        {
            Console.WriteLine("XMLDocument.PrintBody()");
        }
        public override void PrintFooter()
        {
            Console.WriteLine("XMLDocument.PrintFooter()");
        }
    }

    class HTMLDocument : Document
    {
        public override void PrintHeader()
        {
            Console.WriteLine("HTMLDocument.PrintHeader()");
        }
        public override void PrintBody()
        {
            Console.WriteLine("HTMLDocument.PrintBody()");
        }
        public override void PrintFooter()
        {
            Console.WriteLine("HTMLDocument.PrintFooter()");
        }
    }
}
