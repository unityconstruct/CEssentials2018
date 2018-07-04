using System;
using System.Collections.Generic;
using System.Text;

namespace Basics.Projects.EmployeeTrackerOO
{
    class EmployeeTracker
    {
        public static void ProcessEmployeesWithList()
        {
            // define fields
            List<Employee> employees = new List<Employee>();

            //Input Employee Names and Scores
            bool adding = true;
            while (adding)
            {
                var emp = new Employee();
                Console.WriteLine("Employee Name: ");
                emp.Name = Console.ReadLine();

                Console.WriteLine("Employee Score: ");
                emp.Score = int.Parse(Console.ReadLine());

                Console.WriteLine("Employee Birthday: ");
                emp.Birthday = Console.ReadLine();

                Console.WriteLine("Employee Address: ");
                emp.Address = Console.ReadLine();

                Console.WriteLine("Employee Phone: ");
                emp.Phone = double.Parse(Console.ReadLine());

                //Push emp object to the employees List with *.Add(emp)
                employees.Add(emp);

                Console.WriteLine("Add another Employee? y/n");
                adding = (Console.ReadLine().ToLower() == "y") ? true : false;
            }


            //Output Employee Names and Scores
            foreach(var e in employees)
            {
                Console.WriteLine("Employee Name: {0} --- Employee Score: {1}", e.Name, e.Score);
            }

            //decprecated by foreach
            //for (int i = 0; i < employees.Count; i++)
            //{
            //    Console.WriteLine("Employee Name: {0} --- Employee Score: {1}", employees[i].Name, employees[i].Score);
            //}
        }
    }

    class Employee
    {
        public string Name;
        public int Score;
        public string Birthday;
        public string Address;
        public double Phone;
    }
}
