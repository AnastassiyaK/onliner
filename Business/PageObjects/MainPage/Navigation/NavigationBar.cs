using OpenQA.Selenium;
using System;
using System.Globalization;
using System.Linq;

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
                return Decimal.Parse(String.Concat(_currencyValueElement.Text.Where(x => x == ',' || Char.IsDigit(x))), CultureInfo.CreateSpecificCulture("be-BY")); ;
            }
        }
    }
}
