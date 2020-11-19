using System;
using System.Runtime.Remoting.Channels;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _08_Interfaces.Currency
{
    [TestClass]
    public class TransactionTests
    {
        private decimal _debt;

        private void PayDebt(ICurrency payment)
        {
            _debt -= payment.Value;
            Console.WriteLine($"You have paid ${payment.Value} towards your debt!");
        }

        [TestInitialize]  // This will always test this method even when you run test on the methods below.  This means you don't have to call
                          // the Arrange method in the methods below.
        public void Arrange()
        {
            _debt = 9000.13m;
        }
        [TestMethod]
        public void PayDebtTest()
        {
            // Arrange is actually unnecessary here because of the test initialize.
            Arrange();
            PayDebt(new Dollar());
            PayDebt(new ElectronicPayment(532.17m));

            decimal expectedDebt = 9000.13m - 533.17m;

            Assert.AreEqual(_debt, expectedDebt);
        }

        [TestMethod]
        public void InjectingIntoConstructors()
        {
            var dollar = new Dollar();
            var ePayment = new ElectronicPayment(317.2m);

            var firstTransaction = new Transaction(dollar);
            var secondTransaction = new Transaction(ePayment);

            Console.WriteLine(firstTransaction.GetTransactionType());
            Console.WriteLine(secondTransaction.GetTransactionType());

            Assert.AreEqual("Dollar", firstTransaction.GetTransactionType());
            Assert.AreEqual("Electronic Payment", secondTransaction.GetTransactionType());
        }
    }
}
