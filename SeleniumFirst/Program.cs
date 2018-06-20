using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;

namespace SeleniumFirst
{
    class Program
    {
        //Create the reference for the browser
        IWebDriver driver = new ChromeDriver(Directory.GetCurrentDirectory());
        static IWebElement el;

        /*static void Main(string[] args)
        {
         
        }*/
        [OneTimeSetUp]
        public void Initialize()
        {
            //navigate to google page
            driver.Navigate().GoToUrl("https://www.google.com");
            Console.WriteLine("Opened URL");
        }

        [Test]
        public void ExecuteTest()
        {

            // Enter(element,value,type) <-- put elements in new class


            //Find the element
            el = driver.FindElement(By.Name("q"));

            //Perform ops
            el.SendKeys("unityconstruct");

            Console.WriteLine(driver.Title);          //var title = driver.Title;
            Console.WriteLine("Executed Test");
        }


        [Test]
        public void NextTest()
        {
            Console.WriteLine("Next Test");
        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            driver.Close();
            Console.WriteLine("Closed the browser");
        }
    }
}
