using Business;
using Business.Exceptions;
using Business.PageObjects.CurrencyRatesPage;
using Business.PageObjects.CurrencyRatesPage.CurrencyConverterForm;
using Business.PageObjects.MainPage.Navigation;
using Business.TestBase;
using NUnit.Framework;
using System;
using System.Threading;

namespace OnlinerTests.CurrencyTests
{
    [TestFixture]
    public class CurrencyTests : TestBase
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
                if (outConverter == 0)
                {
                    ValidateNumber(number);
                }
                if (number < 0)
                {
                    Assert.AreEqual(new CurrencySection(Driver).GetRowByCurrency(Currency.USD).OtherBankSell.Value * (-1) * number, outConverter);
                }
                else
                {
                    Assert.AreEqual(new CurrencySection(Driver).GetRowByCurrency(Currency.USD).OtherBankSell.Value * number, outConverter);
                }
            }
            catch (NegativeValueException e)
            {
                Assert.Warn(e.Message);
            }
        }

        public void ValidateNumber(int number)
        {
            if (number < 0)
            {
                throw new NegativeValueException(number);
            }
        }

        [Test]
        [Order(3)]
        [TestCaseSource("valuesUSD")]
        public void ConvertUSDToEUR(int number)
        {
            new SelectOptionOut(Driver).SelectCurrency(Currency.EUR);

            new SelectOptionIn(Driver).SelectCurrency(Currency.USD);

            new Converter(Driver).ClearConverter().EnterNumberForConversion(number);      
            
            Assert.AreEqual(Decimal.Round(number/new CurrencyCrossSection(Driver).GetRowByCurrency(Currency.EUR,Currency.USD).OtherBankBuy.Value,4), 
                new OutConverter(Driver).Result);

        }

        public static int[] numbers =
            new int[] { -3, 0, int.MaxValue };

        public static int[] valuesUSD =
            new int[] { 5000,100000 };



    }
}
