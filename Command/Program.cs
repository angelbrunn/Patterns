using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            FileViewer viewer = new FileViewer();
            Command command = new FileOpenCommand(viewer);
            InvokeCommand invoke = new InvokeCommand(command);
            invoke.ExecuteCommand();
        }
    }
}
