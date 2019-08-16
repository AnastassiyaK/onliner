using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using OpenQA.Selenium;

namespace Business.PageObjects.CurrencyRatesPage.NBRB
{
    public class CurrencyNBRB:BestCurrency
    {
        public CurrencyNBRB(IWebElement element) : base(element)
        {
        }

        private IWebElement _deltaRiseElement
        {
            get
            {
                return _element.FindElement(By.ClassName("delta"));
            }
        }
        public decimal DeltaRise
        {
            get
            {
               return Decimal.Parse(_deltaRiseElement.Text, CultureInfo.CreateSpecificCulture("be - BY"));
            }
        }

        //public Currency DeltaRiseCurrency
        //{
        //    get
        //    {
        //        return _element.FindElement(By.ClassName("delta"));
        //    }
        //}

    }
}
