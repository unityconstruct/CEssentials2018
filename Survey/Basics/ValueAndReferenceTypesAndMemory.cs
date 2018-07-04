using System;
using System.Collections.Generic;
using System.Text;

namespace Basics.Basics
{
    class ValueAndReferenceTypesAndMemory
    {
        public static void ValueTypes()
        {
            var x = 2;
            Console.WriteLine("ValueTypes: var x=2");
            Console.WriteLine("ValueTypes: Five(x): Before: {0}", x);
            // passes the VALUE to func so WILL NOT CHANGE ITS VALUE
            Console.WriteLine("ValueTypes: Five(x):calling..");
            Five(x);
            Console.WriteLine("ValueTypes: Five(x): AFTER: {0}", x);
        }

        static void Five(int a)
        {
            a = 5;
            Console.WriteLine("ValueTypes: IN..Fix(int a): assigning a=5");
        }

        public static void ReferenceTypes()
        {
            var x = 2;
            Console.WriteLine("ReferenceTypes: var x=2");
            Console.WriteLine("ReferenceTypes: Six(out int a): Before: {0}", x);
            // passes the VALUE to func 
            //  BUT... 'out' keyword allows that value to be output back to the value in memory
            // so WILL CHANGE ITS VALUE
            Console.WriteLine("ReferenceTypes: Six(out x):calling..");
            Six(out x);
            Console.WriteLine("ReferenceTypes: Six(out int a): AFTER: {0}", x);
        }

        static void Six(out int a)
        {
            a = 6;
            Console.WriteLine("ReferenceTypes: IN..Six(out int a): assigning a=6");
        }
    }
}
