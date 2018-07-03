using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowDemo.PageObjects
{
    public class BaseClassPage
    {
        public static IWebDriver driver;

        public BaseClassPage(IWebDriver driver)
        {
            BaseClassPage.driver = driver;
            driver.Manage().Timeouts().ImplicitWait = System.TimeSpan.FromSeconds(15);
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(15);
        }   
    }
}
