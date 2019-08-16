using Business.PageObjects.CurrencyRatesPage.NBRB;
using Business.PageObjects.CurrencyRatesPage.OtherBanks;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.PageObjects.CurrencyRatesPage
{
    public class CurrencySection:BasePageObject
    {
        public CurrencySection(IWebDriver driver) : base(driver)
        {
        }
        private IWebElement _rowsBestCurrency => _driver.FindElement(By.ClassName("b-currency-table-bg-ii"));


        private CurrencyRow _currencyRow;

        private List<CurrencyRow> _currencyRows;
        
        protected static By GetTagLocatorWithTitle(Currency currency) => By.XPath($"//p[contains(@class,'abbr rate')]//b[contains(text(),'{currency}')]/ancestor::tr[1]");
      

        public CurrencyRow GetRowByCurrency(Currency currency)
        {
            return this._currencyRow ?? (this._currencyRow=new CurrencyRow(_rowsBestCurrency.FindElement(GetTagLocatorWithTitle(currency))));            

        }
       

    }
}
