using System;
using System.Collections.Generic;
using System.Text;

namespace Basics.Basics
{
    class Scope
    {
        private static int intPrivate = 1;
        public static int intPublic = 2;
        private static string strPrivate = "private string";
        public static string strPublic = "public string";

        public static void ScopePublic()
        {
            Console.WriteLine("ScopePublic");
            ScopePrivate();
        }


        private static void ScopePrivate()
        {
            Console.WriteLine("ScopePrivate");
        }

        public static void ScopeInLoops()
        {
            //int k = 1;
            //try
            //{
            //    for (int i = 1; i < 10; i++)
            //    {
            //        // causes compile error
            //        int k = 2;
            //    }
            //} catch
            //{
            //    Console.WriteLine("K is already assigned before the for loop");
            //}
        }

        public static int GetIntPrivate()
        {
            return intPrivate;
        }

        internal static string GetStringPrivate()
        {
            return strPrivate;
        }

        public static void SetIntPrivate(int i)
        {
            intPrivate = i;
        }

        internal static void SetStringPrivate(string s)
        {
            strPrivate = s;
        }


    }
}
