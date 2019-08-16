using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Business.PageObjects.CurrencyRatesPage
{
    public class BestCurrency
    {
        public BestCurrency(IWebElement element)
        {
            _element = element;
        }

        protected IWebElement _element;
        
        private IWebElement _valueElement
        {
            get
            {
                return _element.FindElement(By.CssSelector(".value b"));
            }
        }

        public decimal Value
        {
            get
            {                
                return Decimal.Parse(_valueElement.Text, CultureInfo.CreateSpecificCulture("be-BY"));   
            }
        }

        public Currency Currency
        {
            get
            {
                return Currency.BYN;
            }
        }

        public string Mark
        {
            get
            {
                return "";
            }
        }
    }
}
