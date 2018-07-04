using System;
using System.Collections.Generic;
using System.Text;

namespace Basics.Projects.EmployeeTrackerOO
{
    interface IPayee
    {
        void Pay();
    }
    class Payroll
    {
        Manager mgr1 = new Manager();
        Manager mgr2 = new Manager();
        Executive exec1 = new Executive();

        List<IPayee> payees = new List<IPayee>();
        
        public Payroll()
        {
            payees.Add(new Manager());
            payees.Add(new Manager());
            payees.Add(new Executive());
        }


        public void PayAll()
        {
            foreach (var payee in payees)
            {
                payee.Pay();
            }
        }
    }
}
