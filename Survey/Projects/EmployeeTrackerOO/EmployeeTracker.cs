using System;
using System.Collections.Generic;
using System.Text;

namespace Basics.Projects.EmployeeTrackerOO
{
    enum Business
    {
        Apple = 0,
        Microsoft = 1,
        Samsung = 2
    }

    class EmployeeTracker
    {
        // define fields
        public static List<Employee> employees = new List<Employee>();

        public static void ProcessEmployeesWithList()
        {
            // system is optional now hthat 
            //Logger.Log("Tracker has started", "EmployeeTracker", 1);
            Logger.Log("Tracker has started");
            Logger.Log("Using msg & priority", priority:0);
            Payroll payroll = new Payroll();
            payroll.PayAll();
            
            //Input Employee Names and Scores
            bool adding = true;
            while (adding)
            {
                try
                {
                    Logger.Log("Adding New Student..");
                    var emp = new Employee();


                    // Assign Values to temp employee object
                    emp.Name = Util.EmployeeTrackerUtils.Ask("Employee Name: ");
                    emp.Score = Util.EmployeeTrackerUtils.AskInt("Employee Score:");
                    emp.Business = (Business)Util.EmployeeTrackerUtils.AskInt("Business Index Number: " +
                        "\n0:Apple \n1:Microsoft \n2:Samsung");
                    emp.Birthday = Util.EmployeeTrackerUtils.Ask("Employee Birthday: ");
                    emp.Address = Util.EmployeeTrackerUtils.Ask("Employee Address: ");
                    emp.Phone = Util.EmployeeTrackerUtils.AskDouble("Employee Phone: ");

                    //Push temp employee object to the [employees List] with *.Add(emp)
                    employees.Add(emp);
                    Employee.Count++;
                    Console.WriteLine("Number of Empployees = {0}", Employee.Count);
                    ShowGrade(emp.Name);
                    //Loop?
                    Console.WriteLine("Add another Employee? y/n");
                    adding = (Console.ReadLine().ToLower() == "y") ? true : false;

                }
                catch (FormatException msg)
                {
                    Console.WriteLine(msg.Message);
                }
                catch (Exception)
                {
                    Console.WriteLine("Error Adding Student, Please Retry..");
                    //throw;
                }
                
            }

            
            //Output Employee Names and Scores
            foreach(var e in employees)
            {
                Console.WriteLine("Employee Name: {0} --- Employee Score: {1}", e.Name, e.Score);
            }
            Exports();
        }

        public static void Import()
        {
            //uses Employee constructor for assignments
            var importedEmployee = new Employee("ImportedEmployee", 12, "birthday", "Address", 1234567890);
           // Console.WriteLine(importedEmployee.Name);
        }

        public static void Exports()
        {
            foreach(var employee in employees)
            {
                switch (employee.Business)
                {
                    case Business.Apple:
                        Console.WriteLine("Exporting to Apple");
                        break;
                    case Business.Microsoft:
                        Console.WriteLine("Exporting to Microsoft");
                        break;
                    case Business.Samsung:
                        Console.WriteLine("Exporting to Samsung");
                        break;
                    default:
                        break;
                }
            }
        }

        static void ShowGrade(string name)
        {
            ////Predicate logic
            //var found = employees.Find(predicate);
            //Console.WriteLine("Predicate: {0}'s Grade: {1}", found.Name, found.Score);

            ////lambda logic
            //var foundLambda = employees.Find((employee) =>
            //{
            //    return (employee.Name == "Jones");
            //}
            //);
            //Console.WriteLine("Lambda: {0}'s Grade: {1}", foundLambda.Name, foundLambda.Score);

            ////lambda2 logic without the parens around the object type
            //var foundLambda2 = employees.Find(employee => {return (employee.Name == "Jones");});
            //Console.WriteLine("Lambda2: {0}'s Grade: {1}", foundLambda2.Name, foundLambda2.Score);

            ////lambda3 logic without return & parens for return & curly braces
            //var foundLambda3 = employees.Find(employee => employee.Name == "Jones");
            //Console.WriteLine("Lambda3: {0}'s Grade: {1}", foundLambda3.Name, foundLambda3.Score);

            //lambda4 logic with passed argument name
            var found = employees.Find(employee => employee.Name == name);
            Console.WriteLine("lambda4: {0}'s Grade: {1}", found.Name, found.Score);

        } 

        static bool predicate(Employee employee)
        {
            //can return the condition instead of doing evail with if/then
            return (employee.Name == "Jones");

            //if (employee.Name == "Jones")
            //    return true;
            //else
            //    return false;
        }
    }




    class Member
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public double Phone { get; set; }
    }

    class Employee : Member
    {
        // ONE Field for ENTIRE CLASS, no matter how many instances exist
        // inits to 0 when CONSTUCTOR CALLED on first reference in the program
        public static int Count { get; set; } = 0; 

        // Fields are at class-level w/out get/sets
        public int Score { get; set; }
        public string Birthday { get; set; }
        public Business Business { get; set; } //index of the business name

        public Employee()
        {
             
        }

        public Employee(string name, int score, string birthday, string address, double phone) //constructor
        {
            Score = score;
            Birthday = birthday;
        }

    }


}
