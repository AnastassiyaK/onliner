using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
                return Decimal.Parse(String.Concat(_result.Text.Where(x => x == ',' || Char.IsDigit(x))));
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
