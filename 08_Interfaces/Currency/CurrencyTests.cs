using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _08_Interfaces.Currency
{
    [TestClass]
    public class CurrencyTests
    {
        [TestMethod]
        public void DollarTests()
        {
            ICurrency dollar = new Dollar();

            Assert.AreEqual(1.0m, dollar.Value);
            Assert.AreEqual("Dollar", dollar.Name);
        }

        [DataTestMethod]
        [DataRow(26.2)]
        public void EPaymentTest(double value)
        {
            decimal convertedValue = Convert.ToDecimal(value);

            ElectronicPayment ePayment = new ElectronicPayment(convertedValue);

            Assert.AreEqual(convertedValue, ePayment.Value);
            Assert.AreEqual("Electronic Payment", ePayment.Name);
        }
    }
}
