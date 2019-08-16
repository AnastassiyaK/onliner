using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.PageObjects
{
    public class BasePageObject
    {
        protected IWebDriver _driver;
        public BasePageObject(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
