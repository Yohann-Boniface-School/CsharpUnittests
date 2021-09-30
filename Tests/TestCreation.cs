using BankAccount.classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class TestCreation
    {
        [TestMethod]
        public void TestBalanceCreation0()
        {
            var account = new SavingAccount(0, "foo", "euro");
            Assert.AreEqual(0, account.getBalance());
        }

        [TestMethod]
        public void TestBalanceCreation500()
        {
            var account = new SavingAccount(0, "foo", "euro", 500);
            Assert.AreEqual(500, account.getBalance());
        }
    }
}