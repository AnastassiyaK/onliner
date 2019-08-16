using OpenQA.Selenium;
using System;
using System.Globalization;

namespace Business.PageObjects.MainPage.Navigation
{
    public class NavigationBar:BasePageObject
    {
        public NavigationBar(IWebDriver driver) : base(driver)
        {
        }

        private IWebElement _currencyValueElement
        {
            get
            {
                return _driver.FindElement(By.Id("currency-informer"));
            }
        }
        public Decimal CurrencyValue
        {
            get
            {
                return Decimal.Parse(_currencyValueElement.Text.Substring(1), CultureInfo.CreateSpecificCulture("be-BY")); ;
            }
        }
    }
}
