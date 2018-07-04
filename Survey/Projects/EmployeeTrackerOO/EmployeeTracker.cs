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
                emp.Score = int.Parse(Util.EmployeeTrackerUtils.Ask("Employee Score: "));
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
    }

    class Employee
    {
        // ONE Field for ENTIRE CLASS, no matter how many instances exist
        // inits to 0 when CONSTUCTOR CALLED on first reference in the program
        public static int Count = 0; 

        // Fields are at class-level w/out get/sets
        public string Name;
        public int Score;
        public string Birthday;
        public string Address;
        private double phone; //Properties have get/sets

        public Employee()
        {

        }

        public Employee(string name, int score, string birthday, string address, double phone) //constructor
        {
            Name = name;
            Score = score;
            Birthday = birthday;
            Address = address;
            Phone = phone;
        }
        public double Phone
        {
            set { phone = value; } 
        }



        public void SetPhone(double number)
        {
            phone = number;
        }
    }
}
