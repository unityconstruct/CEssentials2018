using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SpecFlowDemo.Tests
{
    class LoginPage_Tests
    {
        public IWebDriver driver;

        public void Test001()
        {
            driver = new FirefoxDriver();
            new PageObjects.BaseClassPage(driver);
            driver.Url = "https://unityconstruct.org/uc";
            

        }
    }
}
