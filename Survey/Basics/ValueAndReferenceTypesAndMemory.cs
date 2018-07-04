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

        public static void ValueTypesWithOut()
        {
            var x = 2;
            Console.WriteLine("ValueTypesWithOut: var x=2");
            Console.WriteLine("ValueTypesWithOut: Six(out int a): Before: {0}", x);
            // passes the VALUE to func 
            //  BUT... 'out' keyword allows that value to be output back to the value in memory
            // so WILL CHANGE ITS VALUE
            Console.WriteLine("ValueTypesWithOut: Six(out x):calling..");
            Six(out x);
            Console.WriteLine("ValueTypesWithOut: Six(out int a): AFTER: {0}", x);
        }

        static void Six(out int a)
        {
            a = 6;
            Console.WriteLine("ReferenceTypes: IN..Six(out int a): assigning a=6");
        }

        public static void ValueTypesWithRef()
        {
            var x = 2;
            Console.WriteLine("ValueTypesWithRef: var x=2");
            Console.WriteLine("ValueTypesWithRef: Doubled(ref int a): Before: {0}", x);
            // passes the VALUE to func 
            //  BUT... 'out' keyword allows that value to be output back to the value in memory
            // so WILL CHANGE ITS VALUE
            Console.WriteLine("ValueTypesWithRef: Doubled(ref x):calling..");
            Doubled(ref x);
            Console.WriteLine("ValueTypesWithRef: Doubled(ref int a): AFTER: {0}", x);
        }

        static void Doubled(ref int a)
        {
            //ref keyword allows self-referencing calculations
            // AND updating the passed variable
            a = a * 2;
            Console.WriteLine("ValueTypesWithRef: IN..Doubled(ref int a): assigning a=a*2");
        }


        public static void ReferenceTypes()
        {

        }


    }
}
