using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;

namespace SeleniumFirst
{
    class Program
    {
        static IWebDriver driver;
        static IWebElement el;

        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
        }

        public void Initialize()
        {
            //Create the reference for the browser
            driver = new ChromeDriver(Directory.GetCurrentDirectory());
        }

        public void ExecuteTest()
        {
            //navigate to google page
            driver.Navigate().GoToUrl("https://www.google.com");

            //Find the element
            el = driver.FindElement(By.Name("q"));

            //Perform ops
            el.SendKeys("unityconstruct");

            Console.WriteLine(driver.Title);          //var title = driver.Title;
        }

        public void CleanUp()
        {
            driver.Close();
        }
    }
}
