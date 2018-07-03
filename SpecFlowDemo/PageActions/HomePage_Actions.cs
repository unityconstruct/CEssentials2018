using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SpecFlowDemo.PageObjects;

namespace SpecFlowDemo.PageActions
{
    class HomePage_Actions
    {
       public HomePage_Actions()
        {

        }

        public static void HomePage_Menu_Home_Click()
        {
            HomePage.Link_Home().Click();
            Assert.True(HomePage.PageTitle_Get() == "Home | UnityConstruct");

        }

        public static void HomePage_Menu_Login_Click()
        {
            HomePage.Link_Login().Click();
        }

        public static void HomePage_Menu_Search_TextBox_Enter(string search)
        {
            HomePage.TxtBx_Search().SendKeys(search);
        }

        public static void HomePage_Menu_Search_Btn_Click()
        {
            HomePage.Btn_Search().Click();
        }

        public static void HomePage_Menu_Link_ShortcutsToggle()
        {
            HomePage.Link_ShortcutsToggle().Click();
        }

        public static void HomePage_Menu_Link_CreateArticle()
        {
            HomePage.Link_CreateArticle().Click();
        }

        public static void HomePage_Menu_Link_Logout_Click()
        {
            HomePage.Link_Logout().Click();

        }
    }
}
