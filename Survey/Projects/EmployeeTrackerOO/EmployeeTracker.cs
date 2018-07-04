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

                emp.Name = Util.EmployeeTrackerUtils.Ask("Employee Name: ");
                // Udpated for error handling on int.Parse
                emp.Score = int.Parse(Util.EmployeeTrackerUtils.Ask("Employee Score: "));
                bool result = int.TryParse(Util.EmployeeTrackerUtils.Ask("Employee Score: "), out emp.Score);
                if (!result)
                {
                    Console.WriteLine("Age was not an error");
                }

                emp.Birthday = Util.EmployeeTrackerUtils.Ask("Employee Birthday: ");
                emp.Address = Util.EmployeeTrackerUtils.Ask("Employee Address: ");
                emp.Phone = double.Parse(Util.EmployeeTrackerUtils.Ask("Employee Phone: "));

                //Push emp object to the employees List with *.Add(emp)
                employees.Add(emp);
                Employee.Count++;
                Console.WriteLine("Number of Empployees = {0}", Employee.Count);

                Console.WriteLine("Add another Employee? y/n");
                adding = (Console.ReadLine().ToLower() == "y") ? true : false;
            }

            //Output Employee Names and Scores
            foreach(var e in employees)
            {
                Console.WriteLine("Employee Name: {0} --- Employee Score: {1}", e.Name, e.Score);
            }
        }

        public static void Import()
        {
            //uses Employee constructor for assignments
            var importedEmployee = new Employee("ImportedEmployee", 12, "birthday", "Address", 1234567890);
           // Console.WriteLine(importedEmployee.Name);
        }
    }


    class Member
    {
        public string Name;
        public string Address;
        protected double phone;

        public double Phone
        {
            set { phone = value; }
        }
    }

    class Employee : Member
    {
        // ONE Field for ENTIRE CLASS, no matter how many instances exist
        // inits to 0 when CONSTUCTOR CALLED on first reference in the program
        public static int Count = 0; 

        // Fields are at class-level w/out get/sets
        public int Score;
        public string Birthday;

        public Employee()
        {
             
        }

        public Employee(string name, int score, string birthday, string address, double phone) //constructor
        {
            Score = score;
            Birthday = birthday;
        }

    }

    class Manager : Member
    {
        public static int Count = 0;

        public string Name;
        public string Address;
        public string Dept;

        public Manager()
        {

        }
    }
}
