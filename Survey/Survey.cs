using System;
using System.Collections.Generic;
using System.Text;

namespace Basics
{
    class Survey
    {
        public static void AskSurvey()
        {
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();


            Console.WriteLine("What is your age?");
            var age = Console.ReadLine();

            Console.WriteLine("What is your birth month?");
            var month = Console.ReadLine();

            Console.WriteLine("Your name is {0}", name);
            Console.WriteLine("Your age is {0}", age);
            Console.WriteLine("Your birth month is {0}", month);

            if (month.ToLower() == "april")
            {
                Console.WriteLine("Sign is Aries");
            }
            else if (month.ToLower() == "may")
            {
                Console.WriteLine("Sign is Taurus");
            }

        }
    }
}
