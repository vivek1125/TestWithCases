using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestWithCases;
namespace MSTestProject1
{
    [TestClass]
    public class BankAccTest
    {
        [TestMethod]
        public void DebitBalance()
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
        [TestMethod]
        public void DebitForNegative()
        {
            // Arrange
            double beginningBalance = 12.99;
            double debitAmount = -100.00;
            VivekBank account = new VivekBank("Mr. Vivek raj", beginningBalance);

            // Act and assert
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => account.Debit(debitAmount));
        }
    }
}
