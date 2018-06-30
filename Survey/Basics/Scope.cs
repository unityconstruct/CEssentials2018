using System;
using System.Collections.Generic;
using System.Text;

namespace Basics.Basics
{
    class Scope
    {
        private int intPrivate = 1;
        public int intPubcic = 2;
        private string strPrivate = "private string";
        public string strPublic = "public string";

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
            //for(int i = 1; i<10; i++)
            //{
            //    // causes error
            //    int k = 2; 
            //}


        }


    }
}
