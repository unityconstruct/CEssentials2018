using System;
using System.Collections.Generic;
using System.Text;

namespace Basics.Projects.EmployeeTrackerOO
{
    class Logger
    {
        //using Named argument requires static constant variable...
        //..... const is static, so its redundant to use static
        //static string DefaultSystemName = "EmployeeTracker";
        const string DefaultSystemName = "EmployeeTracker";

        //priority type & system that throws log msg
        public static void Log(string msg, string system = DefaultSystemName, int priority=1)
        {
            Console.WriteLine("System: {0}, Priority: {1}, Msg: {2}", system , priority, system);
        }
    }
}
