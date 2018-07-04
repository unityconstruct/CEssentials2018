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
            // MUST RETURN INT ALWAYS
            return 7;
        }

        public static string MethodReturnsString()
        {
            // MUST RETURN STRING ALWAYS
            return "seven";
        }

        public static bool MethodReturnsBool()
        {
            // MUST RETURN Boolean ALWAYS
            return true;
        }

        public static void MethodCallsPrivate()
        {
            // CAN'T RETURN A VALUE
            Console.WriteLine("MethodCallsPrivate(): Calling MethodPrivate()..... ");
            MethodPrivate();
        }
        private static void MethodPrivate()
        {
            // cannot call from outside this class
            Console.WriteLine("Private Method called: MethodPrivate()");
        }

        public static void MethodInputArgs(int num1, string string1)
        {
            // available from outside this class
            Console.WriteLine("MethodInputArgs: with num1={0} and string1={1}...", num1, string1);
        }

    }
}
