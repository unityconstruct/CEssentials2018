using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;

namespace SeleniumFirst
{
    class Program
    {

        static IWebElement el;

        /*static void Main(string[] args)
        {
         
        }*/
        [OneTimeSetUp]
        public void Initialize()
        {
            //Create the reference for the browser
            //IWebDriver driver = new ChromeDriver(Directory.GetCurrentDirectory());
            //replace ALL instances of driver with PropertiesCollection.driver
            //remove method args for driver in SeleniumGet/SetMethods
            PropertiesCollection.driver = new ChromeDriver(Directory.GetCurrentDirectory());

            //navigate to google page
            PropertiesCollection.driver.Navigate().GoToUrl("http://executeautomation.com/demosite/index.html?UserName=&Password=&Login=Login");
            Console.WriteLine("Opened URL");
        }

        [Test]
        public void ExecuteTest()
        {

            // Enter(element,value,type) <-- put elements in new class

            //Title
            SeleniumSetMethods.SelectDropDown("TitleId", "Mr.", PropertyType.Id);

            //Initial
            SeleniumSetMethods.EnterText("Initial", "executeA", PropertyType.Name);

            Console.WriteLine("The value from my Title is:" + SeleniumGetMethods.GetText("TitleId", PropertyType.Id));
            Console.WriteLine("The value from my Initial is:" + SeleniumGetMethods.GetText("Initial", PropertyType.Name));

            //Click Save
            SeleniumSetMethods.Click("Save", PropertyType.Name);

            Console.WriteLine(PropertiesCollection.driver.Title);          //var title = driver.Title;
            Console.WriteLine("Executed Test");
        }


        //[Test]
        //public void NextTest()
        //{
        //    Console.WriteLine("Next Test");
        //}

        [OneTimeTearDown]
        public void CleanUp()
        {
            PropertiesCollection.driver.Close();
            Console.WriteLine("Closed the browser");
        }
    }
}
