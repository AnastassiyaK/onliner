using Business.PageObjects.CurrencyRatesPage.OfficialBank;
using Business.PageObjects.CurrencyRatesPage.OtherBanks;
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
        public AbbreviationCell AbbreviationCell
        {
            get
            {
                return _abbrCell ??
                    (_abbrCell= new AbbreviationCell(_element.FindElement(By.CssSelector("tr:first-of-type td:nth-child(1)"))));
            }
        }
        private OfficialCurrency _officialBankCell;
        public OfficialCurrency OfficialRateCell
        {
            get
            {
                return _officialBankCell ??
                    (_officialBankCell = new OfficialCurrency(_element.FindElement(By.CssSelector("tr:first-of-type td:nth-child(4)"))));
            }
        }
        private BankCurrencySell _bankSell;
        public BankCurrencySell OtherBankSell
        {
            get
            {
                return _bankSell ??
                    (_bankSell = new BankCurrencySell(_element.FindElement(By.CssSelector("tr:first-of-type td:nth-child(2)"))));
            }
        }



    }
}
