using System;

namespace Essentials2017
{
    class Program
    {
        static void Main(string[] args)
        {
            //ConsoleWriteAndReadLine_Runner();



        }

        private static void ConsoleWriteAndReadLine_Runner()
        {
            //Console.WriteLine()
            Console.WriteLine("Hello World!");
            Console.WriteLine("{0}", "Hello World!");
            Console.WriteLine("{0} {1}", "Hello", "World!");

            //Console.ReadLine()
            string input = Console.ReadLine();
            Console.WriteLine("Input value = {0}", input);
        }
    }
}
