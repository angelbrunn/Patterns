using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {      
            // Setup Chain of Responsibility
            Approver to = new TellerOperator();
            Approver abm = new AsstBranchManager();
            Approver bm = new BranchManager();
            to.SetSuccessor(abm);
            abm.SetSuccessor(bm);

            // Generate and process request
            int[] requests = { 2000, 5000, 14000, 22000, 180000, 30000, 20000000, 20000 };

            foreach (int request in requests)
            {
                to.Approve(request);
            }

            // Wait for user
            Console.Read();
        }
    }
}
