using System;
using System.Collections.Generic;
using System.Text;

namespace Basics.Basics
{
    class BaseSubClass : BaseClass
    {
        public BaseSubClass() : base("MessageForBaseClassConstructor")
        {
            Console.WriteLine("Base_SubClass()-Constructor");
        }

        public static void StaticPrintOutSubClass()
        {
            Console.WriteLine("BaseClass.StaticPrintOutSubClass()");
        }
        public void InstancePrintOutSubClass()
        {
            Console.WriteLine("BaseClass.InstancePrintOutSubClass()");
        }

    }
}
