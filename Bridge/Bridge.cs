using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern
{
    abstract class Window
    {
        private WindowImp wndImp;
        private bool isPlatFormX = false;
        private bool isPlatFormMac = true;


        public Window()
        {
            if (this.isPlatFormX)
            {
                wndImp = new XWindowImp();
            }
            else if (this.isPlatFormMac)
            {
                wndImp = new MacWindowImp();
            }
        }

        public virtual void DrawRect()
        {
            wndImp.DrawLine("Left");
            wndImp.DrawLine("Top");
            wndImp.DrawLine("Right");
            wndImp.DrawLine("Bottom");
        }
    }

    class IconWindow : Window
    {
        public override void DrawRect()
        {
            // Single rectangle
            base.DrawRect();
        
        }
    }

    class DialogWindow : Window
    {
        public override void DrawRect()
        {
            // double rectangle
            base.DrawRect();
            base.DrawRect();
        }
    }

    public abstract class WindowImp
    {
        public abstract void DrawLine(string side);
    }

    public class XWindowImp : WindowImp
    {
        public override void DrawLine(string side)
        {
            System.Console.WriteLine("XWindowImp DrawLine >> " + side);
        }
    }

    public class MacWindowImp : WindowImp
    {
        public override void DrawLine(string side)
        {
            System.Console.WriteLine("MacWindowImp DrawLine >> " + side);
        }
    }
}
