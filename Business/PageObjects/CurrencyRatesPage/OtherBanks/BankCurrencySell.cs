using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace Business.PageObjects.CurrencyRatesPage.OtherBanks
{
    public class BankCurrencySell : BestCurrency
    {
        public BankCurrencySell(IWebElement element) : base(element)
        {
        }

        public string WhereToBuyLink
        {
            get
            {
                return "";
            }
        }

        public string WhereToBuyLinkText
        {
            get
            {
                return "";
            }
        }
    }
}

