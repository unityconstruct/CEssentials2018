using System;
using System.Collections.Generic;
using System.Text;

namespace Basics.Projects.EmployeeTrackerOO
{
    // Can only inherit from ONE SuperClass
    // can inherit from MULTIPLE Interfaces
            // MUST hav ALL methods of the interface
    class Executive : Member, IPayee // 
    {
        public void Pay()
        {
            Console.WriteLine("Paying Executive");
        }




    }
}
