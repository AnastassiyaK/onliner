using OpenQA.Selenium;
using System;

namespace Business.PageObjects.CurrencyRatesPage
{
    public class AbbreviationCell
    {
        private IWebElement _element;
        public AbbreviationCell(IWebElement element)
        {
            _element = element;
        }
        private IWebElement _currency
        {
            get
            {
                return _element.FindElement(By.CssSelector("b"));
            }
        }

        public Currency Currency
        {
            get
            {
                
                return (Currency)Enum.Parse(typeof(Currency), _currency.Text);
            }
        }
    }
}
