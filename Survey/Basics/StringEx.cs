using System;
using System.Collections.Generic;
using System.Text;

namespace Basics.Basics
{
    class StringEx
    {

        public static void StringConcatenate()
        {
            Console.WriteLine("Using + is allowed, but not preferred," + " so use the inline method");
            Console.WriteLine("Use arguments inline then append string with the args like: arg0:{0}, arg1:{1}, arg2:{2}", "arg0", "arg1", "arg2");
        }
    }
}
