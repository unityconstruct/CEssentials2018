using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.IO;
using TechTalk.SpecFlow;

namespace SpecFlowDemo
{
    [Binding]
    public class LogIn_FeatureSteps
    {
        IWebDriver driver;

        [Given(@"User is at the Home Page")]
        public void GivenUserIsAtTheHomePage()
        {
            driver = new FirefoxDriver("C:\\Users\\silosix\\source\\repos\\CEssentials2018\\SpecFlowDemo");
            driver.Manage().Timeouts().ImplicitWait = System.TimeSpan.FromSeconds(15);
            driver.Url = "http://www.unityconstruct.org/uc";
            Assert.True(driver.Title == "Home | UnityConstruct");
        }
        
        [Given(@"Navigate to LogIn Page")]
        public void GivenNavigateToLogInPage()
        {
            driver.FindElement(By.XPath("//a[@href='/uc/user/login']")).Click();
            Assert.True(driver.Title == "Log in | UnityConstruct", "Login Page Title is not correct");
        }
        
        [When(@"User enter '(.*)' and '(.*)'")]
        public void WhenUserEnterUserNameAndPassword(string username, string password)
        {
            driver.FindElement(By.Id("edit-name")).SendKeys(username);
            driver.FindElement(By.Id("edit-pass")).SendKeys(password);
        }
        
        [When(@"Click on the LogIn button")]
        public void WhenClickOnTheLogInButton()
        {
            driver.FindElement(By.Id("edit-submit")).Click();
        }
        
        [When(@"User LogOut from the Application")]
        public void WhenUserLogOutFromTheApplication()
        {
            //System.Threading.Thread.Sleep(3000);
            //driver.Url = ("http://www.unityconstruct.org/uc");
            //driver.Navigate();
            //driver.FindElement(By.XPath("//a[@href=/uc/")).Click();

            /*
            bool b = driver.FindElement(By.XPath("//a[@href='/uc/user/logout']")).Enabled;
            Console.WriteLine("Logout link is displayed {0}", b);
            if (b) {
                driver.FindElement(By.XPath("//a[@href='/uc/user/logout']")).Click();
            } else
            {
                Console.WriteLine("Logout link is NOT displayed {0}");
            }
            System.Threading.Thread.Sleep(5000);
            */
        }

        [Then(@"Successful LogIN message should display")]
        public void ThenSuccessfulLogINMessageShouldDisplay()
        {
            bool b = driver.FindElement(By.XPath("//h1[contains(.,'UnityAdmin')]")).Displayed;
            //Console.WriteLine("H1 UserName is displayed {0}", b);
            driver.Quit();
            Assert.True(b, "Login not successful, h1/username not found");
            
        }
        
        [Then(@"Successful LogOut message should display")]
        public void ThenSuccessfulLogOutMessageShouldDisplay()
        {
            /*
            System.Threading.Thread.Sleep(5000);
            bool b = driver.FindElement(By.XPath("//a[@href='/uc/user/login']")).Displayed;
            Console.WriteLine("Login Link is displayed {0}", b);
            driver.Quit();
            */
        }
    }
}
//int timeoutSec = 15000;
//WebDriverWait wait = new WebDriverWait(driver, System.TimeSpan.FromSeconds(timeoutSec));
//wait.Until((driver) => driver.FindElement(By.XPath("//a[@href='/uc/user/login']")).Displayed == true);
//wait.Until((driver) => driver.FindElement(By.XPath("//a[@href='/uc/user/login']")));