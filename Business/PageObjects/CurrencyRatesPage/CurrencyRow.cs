using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Business.PageObjects.CurrencyRatesPage.NBRB;
using OpenQA.Selenium;

namespace Business.PageObjects.CurrencyRatesPage
{
    public class CurrencyRow
    {
        public CurrencyRow(IWebElement element)
        {
            _element = element;
        }
        private IWebElement _element;

        private AbbreviationCell _abbrCell;
        public AbbreviationCell abbrCell
        {
            get
            {
                return _abbrCell ??
                    (_abbrCell= new AbbreviationCell(_element.FindElement(By.CssSelector("tr:first-of-type td:nth-child(1)"))));
            }
        }
        private CurrencyNBRB __nbrbCell;
        public CurrencyNBRB OfficialRateCell
        {
            get
            {
                return __nbrbCell ??
                    (__nbrbCell = new CurrencyNBRB(_element.FindElement(By.CssSelector("tr:first-of-type td:nth-child(4)"))));
            }
        }

       
       
    }
}
