using System;
using System.Collections.Generic;
using System.Text;

namespace Basics.Projects.EmployeeTrackerOO
{
    class Manager : Member, IPayee
    {
        public static int Count = 0;

        public string Name;
        public string Address;
        public string Dept;

        public Manager()
        {

        }

        public void Pay()
        {
            Console.WriteLine("Paying Manager");
        }
    }
}
