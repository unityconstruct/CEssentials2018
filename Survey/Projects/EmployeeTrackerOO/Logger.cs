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
            //String Formatting Syntax
            //Console.WriteLine("StringFormatting: System: {0}, Priority: {1}, Msg: {2}", system , priority, msg);
            //String Interpolation
            Console.WriteLine($"String Interpolation: System: {system}, Priority: {priority}, Msg: {msg}");
        }
    }
}
