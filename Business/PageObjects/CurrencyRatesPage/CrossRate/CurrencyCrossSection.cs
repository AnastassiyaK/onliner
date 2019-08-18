using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace Business.PageObjects.CurrencyRatesPage
{
    public class CurrencyCrossSection : BasePageObject
    {
        public CurrencyCrossSection(IWebDriver driver) : base(driver)
        {
        }
        private IWebElement _rowsBestCurrency => _driver.FindElement(By.ClassName("b-currency-table-bg-ii"));

        private CurrencyRow _currencyRow;

        protected static By GetTagLocatorWithTitle(Currency currencyIn, Currency currencyOut) => By.XPath($"//p[contains(@class,'abbr conversion')]//b[contains(text(),'Кросс-курс {currencyIn} / {currencyOut}')]/ancestor::tr[1]");

        public CurrencyRow GetRowByCurrency(Currency currencyIn, Currency currencyOut)
        {
            return this._currencyRow ?? (this._currencyRow = new CurrencyRow(_rowsBestCurrency.FindElement(GetTagLocatorWithTitle(currencyIn,currencyOut))));

        }
    }
}
