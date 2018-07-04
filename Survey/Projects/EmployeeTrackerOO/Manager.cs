using System;
using System.Collections.Generic;
using System.Text;

namespace Basics.Projects.EmployeeTrackerOO
{
    class Manager : Member, IPayee
    {
        public string Dept { get; set; }

        public Manager()
        {

        }

        public void Pay()
        {
            Console.WriteLine("Paying Manager");
        }
    }
}
