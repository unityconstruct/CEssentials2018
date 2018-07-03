using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowDemo.PageObjects
{
    public class LoginPage : BaseClassPage
    {
        private static IWebElement el;
        public LoginPage(IWebDriver driver) : base(driver)
        {
            
        }

        public static IWebElement Txtbx_Username()
        {
            el = driver.FindElement(By.Id("edit-name"));
            return el;
        }

        public static IWebElement Txtbx_Password()
        {
            el = driver.FindElement(By.Id("edit-pass"));
            return el;
        }

        public static IWebElement Btn_Login()
        {
            el = driver.FindElement(By.Id("edit-submit"));
            return el;
        }

    }
}
