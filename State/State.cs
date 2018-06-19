using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern
{
    public abstract class PrinterState
    {
        public abstract void Handle(Printer context);
        public virtual void Cancel(Printer context)
        { 
            
        }
    }

    class StateReady : PrinterState
    {
        public override void Handle(Printer context)
        {
            Console.WriteLine("Print Started");
            context.State = new StatePrintStart();
        }
    }

    class StatePrintStart : PrinterState
    {
        public override void Handle(Printer context)
        {
            Console.WriteLine("Ready to print");
            context.State = new StatePrinting();
        }
        public override void Cancel(Printer context)
        {
            Console.WriteLine("Canceling ...");
            context.State = new StatePrintEnd();
        }
    }

    class StatePrinting : PrinterState
    {
        public override void Handle(Printer context)
        {
            Console.WriteLine("Printing ...");
            context.State = new StatePrintEnd();
        }
        public override void Cancel(Printer context)
        {
            Console.WriteLine("Canceling ...");
            context.State = new StatePrintEnd();    
        }
    }

    class StatePrintEnd : PrinterState
    {
        public override void Handle(Printer context)
        {
            Console.WriteLine("Print Ended \n");
            context.State = new StateReady();
        }
    }
    // "Context"

    public class Printer
    {
        private PrinterState state;

        // Constructor
        public Printer(PrinterState state)
        {
            this.State = state;
        }

        // Property
        public PrinterState State
        {
            get { return state; }
            set
            {
                state = value;
                //Console.WriteLine("State: " +
                //  state.GetType().Name);
            }
        }

        public void Print()
        {
            state.Handle(this);
        }

        public void Cancel()
        {
            state.Cancel(this);
            state.Handle(this);
        }
    }
}
