using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace Business.TestBase
{
    public class TestBase
    {
        private IWebDriver _driver;

        public IWebDriver Driver
        {
            get
            {
                if (_driver != null)
                    return _driver;
                else
                    throw new NullReferenceException("The WebDriver browser instance was not initialized");
            }
            set
            {
                _driver = value;
            }
        }

        public TestBase()
        {
            InitBrowser();
        }
        [SetUp]
        public void SetUp()
        {
            GoToUrl("https://kurs.onliner.by/");
        }

        [TearDown]
        public void TearDown()
        {
            this._driver.Close();
        }

        public void InitBrowser()
        {

            this._driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));

        }

        public void GoToUrl(string url)
        {
            this._driver.Manage().Window.Maximize();
            this._driver.Navigate().GoToUrl(url);
        }
    }
}
