using System;
using System.Collections.Generic;
using System.Text;

namespace Basics
{
    public class Passcode
    {
        public static void AuthPasscode()
        {
            var code = "";
            var counter = 1;
            while ((code != "secret") && (counter < 4))
            {
                Console.WriteLine("What is the pass code?");
                code = Console.ReadLine();
                if (code != "secret")
                {
                    Console.WriteLine("Not Authenticated");
                }
                Console.WriteLine("Authenticated");
                counter++;
            }
        }
    }
}
