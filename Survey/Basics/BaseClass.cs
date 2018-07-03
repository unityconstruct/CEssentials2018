using System;
using System.Collections.Generic;
using System.Text;

namespace Basics.Basics
{
    class BaseClass
    {
        public BaseClass(string message)
        {
            Console.WriteLine("BaseClass()-Constructor():Passed String: {0}", message);
        }
        public static void StaticPrintOut()
        {
            Console.WriteLine("BaseClass.StaticPrintOut()");
        }
        public void InstancePrintOut()
        {
            Console.WriteLine("BaseClass.InstancePrintOut()");
        }
    }
}
