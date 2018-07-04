using System;
using System.Collections.Generic;
using System.Text;

namespace Basics.Projects
{
    public class Survey
    {
        public static void AskSurvey()
        {
            Console.WriteLine("What is your name?");
            var name = TryAnswer();

            Console.WriteLine("What is your age?");
            var age = TryAnswer();

            Console.WriteLine("What is your birth month?");
            var month = TryAnswer();


            if (month.ToLower() == "april")
            {
                Console.WriteLine("Sign is Aries");
            }
            else if (month.ToLower() == "may")
            {
                Console.WriteLine("Sign is Taurus");
            }


            Console.WriteLine("Your name is {0}", name);
            Console.WriteLine("Your age is {0}", age);
            Console.WriteLine("Your birth month is {0}", month);

        }

        public static string TryAnswer()
        {
            var answer = Console.ReadLine();
            if (answer == "")
            {
                Console.WriteLine("No data entered, Please Try Again");
                return Console.ReadLine();
            }
            return answer;
        }
    }
}
