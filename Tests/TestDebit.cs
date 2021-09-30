using BankAccount.classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class TestDebit
    {
        [TestMethod]
        public void TestBalanceAfterDebit()
        {
            var account = new SavingAccount(0, "foo", "euro", 500);
            account.Debit(100);
            Assert.AreEqual(400, account.getBalance());
        }
        
        [TestMethod]
        public void TestBalanceAfterCredit()
        {
            var account = new SavingAccount(0, "foo", "euro", 500);
            account.Credit(100);
            Assert.AreEqual(600, account.getBalance());
        }
    }
}