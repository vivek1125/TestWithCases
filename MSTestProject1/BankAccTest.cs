using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestWithCases;
namespace MSTestProject1
{
    [TestClass]
    public class BankAccTest
    {
        [TestMethod]
        public void Debit_WithValidAmount_UpdatesBalance()
        {
            // Arrange
            double beginningBalance = 14.56;
            double debitAmount = 4.55;
            double expected = 10.01;
            VivekBank account = new VivekBank("Mr. Vivek raj", beginningBalance);
            account.Debit(debitAmount);
            double actual = account.Balance;
            Assert.AreEqual(expected, actual, 0.001, "Account not debited correctly");
        }
    }
}
