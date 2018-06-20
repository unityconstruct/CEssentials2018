using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumFirst
{

    //'strongly typed' value
    public enum PropertyType
    {
        Id,
        Name,
        LinkText,
        ClassName
    }

    class PropertiesCollection




    {
        //Auto-implemented Properties
        public static IWebDriver driver { get; set; }

    }
}
