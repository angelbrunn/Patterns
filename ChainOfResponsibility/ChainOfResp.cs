using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern
{
    abstract public class Approver
    {
        protected Approver successor;

        public void SetSuccessor(Approver successor)
        {
            this.successor = successor;
        }

        public abstract void Approve(int request);
    }

    class TellerOperator : Approver
    {
        public override void Approve(int request)
        {
            if (request >= 0 && request < 10000)
            {
                Console.WriteLine("{0} handled request {1}",
                  this.GetType().Name, request);
            }
            else if (successor != null)
            {
                successor.Approve(request);
            }
        }
    }

    class AsstBranchManager : Approver
    {
        public override void Approve(int request)
        {
            if (request >= 10000 && request < 100000)
            {
                Console.WriteLine("{0} handled request {1}",
                  this.GetType().Name, request);
            }
            else if (successor != null)
            {
                successor.Approve(request);
            }
        }
    }

    class BranchManager : Approver
    {
        public override void Approve(int request)
        {
            if (request >= 100000 && request < 1000000)
            {
                Console.WriteLine("{0} handled request {1}",
                  this.GetType().Name, request);
            }
            else
            {
                Console.WriteLine("This branch cannot approve your request. Contact head Office");
            }
        }
    }
}
