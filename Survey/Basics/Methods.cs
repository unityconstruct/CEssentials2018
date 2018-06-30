using System;
using System.Collections.Generic;
using System.Text;

namespace Basics.Basics
{
    class Methods
    {
        public static void MethodVoid()
        {

        }

        public static int MethodReturnsInt()
        {
            return 7;
        }

        public static string MethodReturnsString()
        {
            return "seven";
        }

        public static bool MethodReturnsBool()
        {
            return true;
        }

        public static void MethodCallsPrivate()
        {
            Console.WriteLine("MethodCallsPrivate(): Calling MethodPrivate()..... ");
            MethodPrivate();
        }
        private static void MethodPrivate()
        {
            Console.WriteLine("Private Method called: MethodPrivate()");
        }

        public static void MethodInputArgs(int num1, string string1)
        {
            Console.WriteLine("MethodInputArgs: with num1={0} and string1={1}...", num1, string1);
        }

    }
}
