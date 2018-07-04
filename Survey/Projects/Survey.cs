using System;
using System.Collections.Generic;
using System.Text;

namespace Basics.Projects
{

    public class Data
    {
        public string Name;
        public int Age;
        public string Month;

        public void Display()
        {
            Console.WriteLine("Your name is {0}", Name);
            Console.WriteLine("Your age is {0}", Age);
            Console.WriteLine("Your birth month is {0}", Month);

            if (Month.ToLower() == "april")
            {
                Console.WriteLine("Sign is Aries");
            }
            else if (Month.ToLower() == "may")
            {
                Console.WriteLine("Sign is Taurus");
            }
        }
        
    }
    public class Survey
    {
        public static void AskSurvey()
        {
            Data thisData = new Data();

            Console.WriteLine("What is your name?");
            thisData.Name = TryAnswer();

            Console.WriteLine("What is your age?");
            thisData.Age = int.Parse(TryAnswer());

            Console.WriteLine("What is your birth month?");
            thisData.Month = TryAnswer();




            thisData.Display();
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
