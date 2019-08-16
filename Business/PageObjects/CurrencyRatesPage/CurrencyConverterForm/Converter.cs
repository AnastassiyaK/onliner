using OpenQA.Selenium;

namespace Business.PageObjects.CurrencyRatesPage.CurrencyConverterForm
{
    public class Converter : BasePageObject
    {
        public Converter(IWebDriver driver) : base(driver)
        {
        }

        public void EnterNumberForConversion(int number)
        {
            _driver.FindElement(By.Id("amount-in")).SendKeys(number.ToString());
        }
    }
}
