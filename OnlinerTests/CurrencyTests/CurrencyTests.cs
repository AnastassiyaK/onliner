using Business;
using Business.PageObjects.CurrencyRatesPage;
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
        [TestCaseSource("Numbers")]
        public void CheckInputForConversion(int negative, int zero, int maxValueInt)
        {

        }

        [Test]
        [Order(3)]

        public void ConvertUSDToEUR()
        {

        }

        public static object[] numbers =
            { new object[] { -3,0,int.MaxValue} };


    }
}
