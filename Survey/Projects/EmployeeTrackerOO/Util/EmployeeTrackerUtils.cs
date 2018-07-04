using System;
using System.Collections.Generic;
using System.Text;

namespace Basics.Projects.EmployeeTrackerOO.Util
{
    class EmployeeTrackerUtils
    {
        public static string Ask(string question)
        {
            System.Console.WriteLine(question);
            return Console.ReadLine();
        }

        public static int AskInt(string question)
        {

            try
            {
                System.Console.WriteLine(question);
                // original before the extension method toInt()
                //return int.Parse(Console.ReadLine());
                return Console.ReadLine().toInt();
            }
            catch (Exception)
            {
                // throws the error message up to calling methods
                throw new FormatException("Input was not a number");
            }
        }
        public static double AskDouble(string question)
        {
            try
            {
                System.Console.WriteLine(question);
                return double.Parse(Console.ReadLine());
            }
            catch(Exception)
            {
                // throws the error message up to calling methods
                throw new FormatException("Input was not a number");
            }
        }
    }
}
