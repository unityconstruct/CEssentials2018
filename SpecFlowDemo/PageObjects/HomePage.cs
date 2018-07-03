using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowDemo.PageObjects
{
    public class HomePage : BaseClassPage
    {
        private static IWebElement el;

        public HomePage(IWebDriver driver) : base(driver)
        {

        }

        public static string PageTitle_Get()
        {
            return driver.Title;
        }

        public static IWebElement Link_Login()
        {
            el = driver.FindElement(By.XPath("//a[@href='/uc/user/login']"));
            return el;
        }

        public static IWebElement Link_Logout()
        {
            el = driver.FindElement(By.LinkText("Log out"));
            return el;
        }

        public static IWebElement Link_Home()
        {
            el = driver.FindElement(By.XPath("//a[contains(.,'Home')]"));
            return el;
        }
        
        public static IWebElement Link_Music()
        {
            el = driver.FindElement(By.XPath ("//a[contains(.,'Music')]"));
            return el;
        }

        public static IWebElement Link_Computing()
        {
            el = driver.FindElement(By.XPath ("//a[@href='/uc/computing']"));
            return el;
        }

        // method to produce 'element not found' error
        public static IWebElement Link_Error()
        {
            el = driver.FindElement(By.XPath("//a[contains(.,'Error')]"));
            return el;
        }

        public static IWebElement TxtBx_Search()
        {
            el = driver.FindElement(By.Id("edit-keys"));
            return el;
        }
        public static IWebElement Btn_Search()
        {
            el = driver.FindElement(By.Id("edit-submit"));
            return el;
        }

        //ADD WAIT UNTIL
        public static IWebElement Link_ShortcutsToggle()
        {
            if (!driver.FindElement(By.XPath("//a[@href='/uc/node/add/article']")).Displayed)
            {
                el = driver.FindElement(By.Id("toolbar-item-shortcuts"));
            }
            return el;

        }
        public static IWebElement Link_CreateArticle()
        {
            el = driver.FindElement(By.XPath("//a[@href='/uc/node/add/article']"));
            return el;
        }
    }
}
