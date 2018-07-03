using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpecFlowDemo.PageObjects;

namespace SpecFlowDemo.PageActions
{
    class LoginPage_Actions
    {
        IWebElement el;
        public LoginPage_Actions()
        {

        }

        public static void LoginPage_TxtBx_Username(string name)
        {
            LoginPage.Txtbx_Username().SendKeys(name);
        }
        public static void LoginPage_TxtBx_Password(string password)
        {
            LoginPage.Txtbx_Password().SendKeys(password);
        }
        public static void LoginPage_Btn_Login_Click()
        {
            LoginPage.Btn_Login().Click();
        }
    }
}
