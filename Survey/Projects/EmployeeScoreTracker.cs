using System;
using System.Collections.Generic;
using System.Text;

namespace Basics.Projects
{
    public class EmployeeScoreTracker
    {
        public EmployeeScoreTracker()
        {

        }

        public static void ProcessEmployees()
        {
            //Enter Employee Count           
            Console.WriteLine("Enter number of employees");
            int empCount = int.Parse(Console.ReadLine());
            string[] empNames = new string[empCount];
            int[] empScores = new int[empCount];


            //Input Employee Names and Scores
            for (int i = 0; i < empCount; i++)
            {
                Console.WriteLine("Employee Name: ");
                empNames[i] = Console.ReadLine();
                Console.WriteLine("Employee Score: ");
                empScores[i] = int.Parse(Console.ReadLine());
            }

            //Output Employee Names and Scores
            for (int i = 0; i< empCount; i++)
            {
                Console.WriteLine("Employee Name: {0} --- Employee Score: {1}", empNames[i],empScores[i]);
            }
        }

        public static void ProcessEmployeesWithList()
        {
            //Enter Employee Count           
            //Console.WriteLine("Enter number of employees");
            //int empCount = int.Parse(Console.ReadLine());
            List<string> empNames = new List<string>();
            List<int> empScores = new List<int>();


            //Input Employee Names and Scores
            bool adding = true;
            while (adding)
            {
                Console.WriteLine("Employee Name: ");
                empNames.Add(Console.ReadLine());
                Console.WriteLine("Employee Score: ");
                empScores.Add(int.Parse(Console.ReadLine()));
                Console.WriteLine("Add another Employee? y/n");
                adding = (Console.ReadLine().ToLower() == "y") ? true : false;
            }


            //Output Employee Names and Scores
            for (int i = 0; i < empNames.Count; i++)
            {
                Console.WriteLine("Employee Name: {0} --- Employee Score: {1}", empNames[i], empScores[i]);
            }
        }

    }
}
