using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumFirst
{
    class EAPageObject
    {
        public EAPageObject()
        {

        }


        [FindsBy(How = How.Id, Using ="TitleId")]
        public IWebElement TitleID { get; set; }


        [FindsBy(How = How.Name, Using = "Initial")]
        public IWebElement txtInitial { get; set; }

        [FindsBy(How = How.Name, Using = "Save")]
        public IWebElement btnSave { get; set; }

    }
}
