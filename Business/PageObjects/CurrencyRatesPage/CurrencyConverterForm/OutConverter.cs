using System;
using System.Globalization;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Business.PageObjects.CurrencyRatesPage.CurrencyConverterForm
{
    public class OutConverter : BasePageObject
    {
        public OutConverter(IWebDriver driver) : base(driver)
        {
        }
        private IWebElement _result
        {
            get
            {
                return _driver.FindElement(By.CssSelector("#converter-out .js-cur-result"));
            }
        }

        public decimal Result
        {
            get
            {
                return Decimal.Parse(String.Concat(_result.Text.Where(x => x == ',' || Char.IsDigit(x))), CultureInfo.CreateSpecificCulture("be-BY"));
            }
        }

        public Currency Currency
        {
            get;
        }

        public SelectElement CurrencySelector
        {

            get;
        }

    }
}
