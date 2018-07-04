using System;
using System.Collections.Generic;
using System.Text;

namespace Basics.Basics
{
    public class WriteAndReadLine
    {
        public static void ConsoleWriteLine()
        {
            //Console.WriteLine()
            Console.WriteLine("Hello World!");
            Console.WriteLine("{0}", "Hello World!");
            Console.WriteLine("{0} {1}", "Hello", "World!");
        }

        public static void ConsoleReadLine()
        {
            //Console.ReadLine()
            string input = Console.ReadLine();
            Console.WriteLine("Input value = {0}", input);
        }
    }
}
