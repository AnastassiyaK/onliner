using OpenQA.Selenium;
using System;
using System.Globalization;

namespace Business.PageObjects.CurrencyRatesPage.OfficialBank
{
    public class OfficialCurrency:BestCurrency
    {
        public OfficialCurrency(IWebElement element) : base(element)
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
    }
}
