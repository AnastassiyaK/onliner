using Business;
using Business.Exceptions;
using Business.PageObjects.CurrencyRatesPage;
using Business.PageObjects.CurrencyRatesPage.CurrencyConverterForm;
using Business.PageObjects.MainPage.Navigation;
using Business.TestBase;
using NUnit.Framework;

namespace OnlinerTests.CurrencyTests
{
    [TestFixture]
    public class CurrencyTests:TestBase
    {
        [Test]
        [Order(1)]
        public void CheckСoincidenceCurrentDollarRate()
        { 
            Assert.IsTrue(new CurrencySection(Driver).GetRowByCurrency(Currency.USD).OfficialRateCell.Value == new NavigationBar(Driver).CurrencyValue);
        }

        [Test]
        [Order(2)]
        [TestCaseSource("numbers")]
        public void CheckInputForConversion(int number)
        {
            try
            {
                new Converter(Driver).ClearConverter().EnterNumberForConversion(number);
                var outConverter = new OutConverter(Driver).Result;
                if (outConverter==0)
                {
                    ValidateNumber(number);
                }
                Assert.AreEqual(new CurrencySection(Driver).GetRowByCurrency(Currency.USD).OtherBankCell.Value*number, outConverter);
            }
            catch(NegativeValueException e)
            {
                Assert.Warn(e.Message);
            }
        }

        public void ValidateNumber(int number)
        {
            if (number<0)
            {
                throw new NegativeValueException(number);
            }
        }

        [Test]
        [Order(3)]

        public void ConvertUSDToEUR()
        {

        }

        public static object[] numbers =
            { new object[] { 0 } };

        //-3,0,int.MaxValue
    }
}
