using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.IO;
using TechTalk.SpecFlow;
using SpecFlowDemo.PageActions;

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
            new PageObjects.BaseClassPage(driver);
            driver.Url = "https://unityconstruct.org/uc";
            Assert.True(driver.Title == "Home | UnityConstruct");
        }
        
        [Given(@"Navigate to LogIn Page")]
        public void GivenNavigateToLogInPage()
        {
            HomePage_Actions.HomePage_Menu_Login_Click();
            Assert.True(driver.Title == "Log in | UnityConstruct", "Login Page Title is not correct");
        }
        
        [When(@"User enter '(.*)' and '(.*)'")]
        public void WhenUserEnterUserNameAndPassword(string username, string password)
        {
            LoginPage_Actions.LoginPage_TxtBx_Username(username);
            LoginPage_Actions.LoginPage_TxtBx_Password(password);
        }
        
        [When(@"Click on the LogIn button")]
        public void WhenClickOnTheLogInButton()
        {
            LoginPage_Actions.LoginPage_Btn_Login_Click();
        }
        
        [When(@"User LogOut from the Application")]
        public void WhenUserLogOutFromTheApplication()
        {

            HomePage_Actions.HomePage_Menu_Home_Click();
            HomePage_Actions.HomePage_Menu_Link_Logout_Click();


            System.Threading.Thread.Sleep(5000);
        }

        [Then(@"Successful LogIN message should display user '(.*)'")]
        public void ThenSuccessfulLogINMessageShouldDisplayUser(string username)
        {
            bool b = driver.FindElement(By.XPath("//h1[contains(.,'"+ username+"')]")).Displayed;
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
        
        [Then(@"User closes browser")]
        public void UserClosesBrowser()
        {
            driver.Quit();
        }

        public void TrashBin()
        {
            //From Home Page method
            //System.Threading.Thread.Sleep(3000);
            //driver.Url = ("http://www.unityconstruct.org/uc");
            //driver.Navigate();


            //From Logout method
            //driver.FindElement(By.XPath("//a[@href=/uc/")).Click();
            //bool b = driver.FindElement(By.XPath("//a[@href='/uc/user/logout']")).Enabled;
            //Console.WriteLine("Logout link is displayed {0}", b);
            //if (b) {
            //    driver.FindElement(By.XPath("//a[@href='/uc/user/logout']")).Click();
            //} else
            //{
            //    Console.WriteLine("Logout link is NOT displayed {0}");
            //}


            // Wait logic.. OK to use? Add to WebDriverUtils?
            //int timeoutSec = 15000;
            //WebDriverWait wait = new WebDriverWait(driver, System.TimeSpan.FromSeconds(timeoutSec));
            //wait.Until((driver) => driver.FindElement(By.XPath("//a[@href='/uc/user/login']")).Displayed == true);
            //wait.Until((driver) => driver.FindElement(By.XPath("//a[@href='/uc/user/login']")));
        }
    }
}
