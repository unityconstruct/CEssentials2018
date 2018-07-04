using System;
using System.Collections.Generic;
using System.Text;

namespace Basics.Projects.EmployeeTrackerOO.Util
{
    class EmployeeTrackerUtils
    {
        public static string Ask(string question)
        {
            System.Console.WriteLine(question);
            return Console.ReadLine();
        }
    }
}
