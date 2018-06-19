using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Document xml = new XMLDocument();
            Document html = new HTMLDocument();
            xml.Print();
            html.Print();
        }
    }
}
