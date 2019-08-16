using Business;
using Business.PageObjects.CurrencyRatesPage;
using Business.TestBase;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlinerTests.CurrencyTests
{
    [TestFixture]
    public class CurrencyTests:TestBase
    {
        [Test]
        [Order(1)]
        public void CheckСoincidenceCurrentDollarRate()
        {
            var currency = new CurrencySection(Driver).GetRowByCurrency(Currency.USD).OfficialRateCell.Value;
            Assert.IsTrue(currency == (decimal)2.0457d);
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
