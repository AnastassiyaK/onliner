using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Business.PageObjects.CurrencyRatesPage.CurrencyConverterForm
{
    public class SelectOptionIn : BasePageObject
    {
        public SelectOptionIn(IWebDriver driver) : base(driver)
        {
        }

        private SelectElement _currency;
        private SelectElement Currency
        {
            get
            {
                return _currency ??
                    (_currency = new SelectElement(_driver.FindElement(By.Id("currency-in"))));
            }
        }

        public void SelectCurrency(Currency currency)
        {
            Currency.SelectByText(currency.ToString());
        }
    }
}
