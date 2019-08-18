using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.PageObjects.CurrencyRatesPage.OtherBanks
{
    public class BankCurrencyBuy:BestCurrency
    {
        public BankCurrencyBuy(IWebElement element) : base(element)
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
